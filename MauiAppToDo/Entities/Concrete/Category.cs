using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın 
    
    
    public class Category:IEntity //Category bir verş tabanı tablosudur
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
