using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ToDoContext>, IUserDal
    {
        // ÜRÜNE AİT ÖZEL OPERASYONLERI GETİRMEK İÇİN YAPILDI
        public List<UserToDoDetailDto> GetUserToDoDetails()
        {
            using (ToDoContext context = new ToDoContext())
            {
                var result = from p in context.UserTable
                             join c in context.ToDoListTable
                             on p.ID equals c.UserId
                             select new UserToDoDetailDto
                             {
                                 UserId = p.ID,
                                 UserName=p.UserName,
                                 Email=p.Email,
                                 ToDoListTitle=c.ToDoListTitle,
                                 ToDoListIsComplated=c.ToDoListIsComplated,
                             };
              return result.ToList();
            }
        }
    }
}
