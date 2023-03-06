using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //product ile ilgili veri tabanında yapılacak olan operasyonları içeren interface dir
    // operasyon -> sil güncelle filtrele getir vs
    public interface IProductDal:IEntityRepository<Product>
    {
   
    }
}
