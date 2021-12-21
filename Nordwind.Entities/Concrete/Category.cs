using Nordwind.Entities.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordwind.Entities.Concrete
{
    //ADIM-1
    //Tanımlamalara ilkönce buradan başla
    //Bir nesne tanımlıyoruz, tanımlanan nesne IEntity üyesi olduğunu bilsin.
    public class Category:IEntity
    {
        public  int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
