using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ToDoList:IEntity
    {
        public int ID { get; set; }
        public string ToDoListTitle { get; set; }
        public string ToDoListDescription { get; set; }
        public bool ToDoListIsComplated { get; set; }
        public int UserId { get; set; }



    }
}
