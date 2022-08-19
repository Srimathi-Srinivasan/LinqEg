using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    internal class Product
    {
        
        public int Pid{get;set;}
        public string Pname{get;set;}
        public int Price{get;set;}

        public Product()
        {

        }
        public Product(int pid,string pname,int price)
        {
            Pid = pid;
            Pname = pname;
            Price = price;
        }

        public static List<Product> prod = new List<Product>();
        public static List<Product> getallprods()
        {
            
            prod.Add(new Product(1,"Pen",30));
            prod.Add(new Product(2, "Pencil", 10));
            prod.Add(new Product(3, "Eraser", 5));
            //foreach(var p in prod)
            //{
            //    Console.WriteLine(p);
            //}
            return prod;
        }
        
        public static Product getprodbyId(int pid)
        {
            //var product = (from p in prod
            //              where p.Pid == pid
            //              select p).SingleOrDefault();
            var product = prod.Where(x => x.Pid == pid).Select(x => x).SingleOrDefault();
            return product;
        }

        public static void AddProd()
        {
            Console.WriteLine("Enter Pid,Pname and Price: ");
            Product p = new Product();
            p.Pid = Convert.ToInt32(Console.ReadLine());
            p.Pname = Console.ReadLine();
            p.Price = Convert.ToInt32(Console.ReadLine());
            prod.Add(p);
        }
        public override string ToString()
        {
            return String.Format(Pid + " " + Pname + " " + Price);
        }
    }
}
