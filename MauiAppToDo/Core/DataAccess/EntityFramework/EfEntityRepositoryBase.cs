using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    // entity frameworku kullanılarak bir repository oluşturuluyor
    // TEntity -> çalışılacak tablo ismi 
    // TContext -> çalışılacak context ismi 
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDısposable pattern impementation
            //using bittiği anda belleği temizler
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //referansı yakalar
                addedEntity.State = EntityState.Added; // eklenecek bir nesne
                context.SaveChanges();  // ekle      // SaveChanges-> buradaki işlemleri yapar                     
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()  //SELECT * FROM MANTIĞI GİBİ
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
