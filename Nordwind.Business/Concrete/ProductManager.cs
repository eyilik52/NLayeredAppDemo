using FluentValidation;
using Nordwind.Business.Abstruct;
using Nordwind.Business.ValidationRules.FluentValidation;
using Nordwind.DataAccess.Abstruct;
using Nordwind.DataAccess.Concrete;
using Nordwind.DataAccess.Concrete.EntityFramework;
using Nordwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordwind.Business.Concrete
{
    
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {            
            _productDal = productDal; 
        }

        public void Add(Product product)
        {
            //Validation çağırma alanı
            ProductValidator productValidator = new ProductValidator();
            var result =productValidator.Validate(product);
            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);
            }
            _productDal.Add(product);//önceden sadece bu kod bloğu vardı
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            //Bussiness kodları yazılacak.
            return _productDal.GetAll();//buradaki getall dataaccessteki GetAll'dır.
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
