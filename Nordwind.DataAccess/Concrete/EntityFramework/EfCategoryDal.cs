using Nordwind.DataAccess.Abstruct;
using Nordwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordwind.DataAccess.Concrete.EntityFramework
{
    //Adım-4 
    //EfCategoryDal sınıfını tanımla, EfEntityRepositoryBase sınıfından referans al işlem bitti.
    //Son olarak form kısmından çağırmaya başla
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NordwindContext>,ICategoryDal
    {

    }
}
