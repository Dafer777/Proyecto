using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int categoryId { get; set; } //este entra en relacion con Category

        public static List<Product> GetProductos()
        {
            List<Product> Products = new List<Product>
            {
                new Product {ProductId= "5030", ProductName="Mouse Gamer Razer", Price= 50.00d, categoryId=3001},
                new Product {ProductId= "5031", ProductName="Teclado Razer Hunstman", Price= 100.00d, categoryId=3002},
                new Product {ProductId= "5032", ProductName="Camara logitech c920", Price= 75.00d, categoryId=3003},
                new Product {ProductId= "5033", ProductName="Mouse MSI DS200", Price= 55.00d, categoryId=3001},
                new Product {ProductId= "5034", ProductName="Audifonos razer Light", Price= 45.00d, categoryId=3004}
            };
            return Products;
        }
    }
}
