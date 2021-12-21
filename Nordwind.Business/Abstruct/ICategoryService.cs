using Nordwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordwind.Business.Abstruct
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
