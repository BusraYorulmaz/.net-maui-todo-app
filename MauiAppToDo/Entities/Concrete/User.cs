using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        
    }
}
