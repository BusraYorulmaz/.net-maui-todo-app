using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserToDoDetailDto: IDto
    {
        public int UserId  { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ToDoListTitle { get; set; }
        public bool ToDoListIsComplated { get; set; }
      

    }
}
