using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // bir iş sınıfı başka bir iş sınıfını new lemez
    //ProductManager -> iş katmanının somut sınıfı
    public class ProductManager : IProductService
    {
        IProductDal  _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
             //iş kodları 
             // yetki var mı? varsa ürünleri getir
            return _productDal.GetAll();
        }
    }
}
