using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IToDoListService
    {
        List<ToDoList> GetAll();
        ToDoList GetById(int UserId);

    }
}
