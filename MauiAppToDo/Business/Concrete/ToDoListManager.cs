using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

      
        public List<ToDoList> GetAll()
        {
            //iş kodları buraya yazılır
            return _toDoListDal.GetAll(); 
        }

        //select * from ToDoListTable where UserId = 3 
        public ToDoList GetById(int UserId)
        {
             return _toDoListDal.Get(c=>c.UserId == UserId);
        }
    }
}
