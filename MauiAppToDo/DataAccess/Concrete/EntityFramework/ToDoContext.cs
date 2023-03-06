using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : db tabloları ile proje class larını bağlamak
    public class ToDoContext:DbContext
    {

        // Database bağlantısı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2F22P0S;Database=tododb;Trusted_Connection=true");     
        }

        // Class ve Tabloları bir biri ile eşleştirme
        public DbSet<User> UserTable { get; set; }
        public DbSet<ToDoList> ToDoListTable { get; set; }


    }
}
