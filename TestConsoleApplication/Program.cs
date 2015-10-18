using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestConsoleApplication.Data;

namespace TestConsoleApplication
{
    public class Program
    {
        public void Main(string[] args)
        {
            using(var context = new SalesContext())
            {
                var products = context.Product.ToList();
                foreach(var p in products){
                    
                    Console.WriteLine(p.Category.CategoryName + "  " + p.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
