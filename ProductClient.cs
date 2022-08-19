using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    internal class ProductClient
    {
        public static List<Product> products = new List<Product>();
        //Product p = new Product();
        public static void Main()
        {
            products = Product.getallprods();
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
            Product p = Product.getprodbyId(3);
            Console.WriteLine(p.ToString());
        }
    }
}
