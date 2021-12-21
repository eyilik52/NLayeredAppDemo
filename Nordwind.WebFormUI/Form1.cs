using Nordwind.Business.Abstruct;
using Nordwind.Business.Concrete;
using Nordwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nordwind.WebFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();//Ürünleri Listele
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadProduct()
        {
            DgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try //Daha değerler dolmadan yüklemeye çalışacağındanilk seferinde hata almamak için...
            {
                DgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {

                
            }
            
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProduct.Text))
            {
                DgwProduct.DataSource = _productService.GetProductsByProductName(txtProduct.Text);
            }
            else
            {
                LoadProduct();
            }
            
        }
    }
}
