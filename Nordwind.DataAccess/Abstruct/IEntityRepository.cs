using Nordwind.Entities.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nordwind.DataAccess.Abstruct
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);//Kullanıcı isterse filtre vermek zorunda değil.
        T Get(Expression<Func<T, bool>> filter);
        //Burada filtre vermek zorunda
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
