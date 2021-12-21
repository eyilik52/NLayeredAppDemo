using Nordwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordwind.DataAccess.Abstruct
{
    //Adım-3 interface tanımla...
    //IEntityRepositoryden category adına implement et
    public interface ICategoryDal:IEntityRepository<Category>
    {

    }
}
