using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public static List<Category> GetCategory()
        {
            List<Category> Categorys = new List<Category>
            {
             new Category {CategoryID= 3001,CategoryName="Mouse"},
             new Category{CategoryID=3002,CategoryName="Keyboard"},
             new Category{CategoryID=3003,CategoryName="Camara"},
             new Category{CategoryID=3004,CategoryName="Audifonos"}
            };

            return Categorys;
        }
    }
}
