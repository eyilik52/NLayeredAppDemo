using FluentValidation;
using Nordwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //Fluent validation dökümantasyonuna bak.

            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Boş geçilemez...");//Boş olamaz...
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            //Başlangıçta sıfır, dönüş tipi int olduğu için (short) ekledik.
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);
            //KategoriId 2 olan ürün 10dan aşağı olamaz.
        }
    }
}
