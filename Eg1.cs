using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    internal class Eg1
    {
        public static void main()
        {
            List<int> numbers = new List<int>();
            numbers.Add(15);
            numbers.Add(30);
            numbers.Add(9);
            numbers.Add(10);
            var res1 = (from i in numbers
                      where i > 10
                      select i).ToList();
            foreach(int item in res1)
            {
                Console.WriteLine(item);
            }

            //Method syntax

            var result1 = numbers.Where(x => x > 10).Select(x => x);
            foreach(var item in result1)
            {
                Console.WriteLine(item);
            }
            //Query syntax
            List<string> fruits = new List<string> { "apple", "orange", "banana", "papaya", "avacado" };
            var res2 = from i in fruits
                       where i.StartsWith("a")
                       select i;
            foreach(var item in res2)
            {
                Console.WriteLine(item);
            }
            //Method Syntax
            //List<string> result2 = new List<string> (fruits.Where(x => x.StartsWith("a")).Select(x => x));
            List<string> result2 = fruits.Where(x => x.StartsWith("a")).Select(x => x).ToList();  //both syntax correct
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
