using Nordwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordwind.DataAccess.Concrete.EntityFramework
{
    //ADIM-2
    //Oluşturulan varlık için DbSet tanımlıyoruz.
    public class NordwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
