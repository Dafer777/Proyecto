using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public static string cod = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //llamado al metodo utilizado para llenar el combobox
            fillCombobox();

            //llamado al metodo para mostrar los datos del dataGriedView
            fillDataGridView();

        }

        private void fillCombobox()
        {
            List<string> categorys = (
                //consula con LINQ
                from Category in Category.GetCategory()
                select Category.CategoryName
                ).ToList();
            //llenar el comboBox
            foreach (var Cat in categorys)
                cboDepartments.Items.Add(Cat);
        }


        private void fillDataGridView()
        {
            //consulta para unir dos colecciones (Category, Product)
            var JoinData = Product.GetProductos()
                .Join                          //operador de union
                (
                     Category.GetCategory(),
                    //campos coincidentes, o datos coincidentes
                    Product => Product.categoryId,
                     Category => Category.CategoryID,
                    (Product, Category) => new
                    {
                        //elementos a seleccionar
                        ProductID = Product.ProductId,
                        NameProduct = Product.ProductName,
                        Price = Product.Price,
                        Category = Category.CategoryName
                    }
                ).ToList();

            //llenar el datagridview
            dgData.Columns.Add("productid", "ID PRODUCTO");
            dgData.Columns.Add("nameproduct", "NOMBRE PRODUCTO");
            dgData.Columns.Add("price", "PRECIO");
            dgData.Columns.Add("category", "CATEGORIA");

            foreach (var data in JoinData)
            {
                dgData.Rows.Add(
                    data.ProductID,
                    data.NameProduct,
                    data.Price,
                    data.Category
                    );
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            clearDataGridView(); //limpiamos DataGridView y luego cargamos nuevamente los datos
            fillDataGridView(); //llenado de DataGridView
        }
        private void clearDataGridView()
        {
            dgData.Columns.Clear(); //limpia las columnas/elimina las columnas
            dgData.Rows.Clear(); //eliminar filas
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            clearDataGridView(); //limpiamos DataGridView y luego cargamos nuevamente los datos
            fillDataGridView(); //llenado de DataGridView
        }


        private void filterbyCategory()
        {
            var ProductCategory = (
                from Product in Product.GetProductos()
                join Category in Category.GetCategory() on
                Product.categoryId equals Category.CategoryID
                where Category.CategoryName == cboDepartments.Text
                orderby Category.CategoryName descending
                select new
                {
                    ProductID = Product.ProductId,
                    NameProduct = Product.ProductName,
                    Price = Product.Price,
                    Category = Category.CategoryName
                }
                ).ToList();

            //llenar el datagridview
            dgData.Columns.Add("productid", "ID PRODUCTO");
            dgData.Columns.Add("nameproduct", "NOMBRE PRODUCTO");
            dgData.Columns.Add("price", "PRECIO");
            dgData.Columns.Add("category", "CATEGORIA");
            
            foreach(var category in ProductCategory)
            {
                dgData.Rows.Add(
                    category.ProductID,
                    category.NameProduct,
                    category.Price,
                    category.Category
                    );
            }
        }
        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pasamos el codigo del empleado al formulario EmployeeForm
            cod = dgData.CurrentRow.Cells[0].Value.ToString();

            //cargar el formulario EmployeeForm
            ProductForm product = new ProductForm();
            product.Show(); //mostrar formulario EmployeeForm
        }

    }
}
