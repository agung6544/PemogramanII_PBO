using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220039
{
    class ProductTest_714220039
    {
        static void Main(string[] args)
        {
            Book_714220039 product1 = new Book_714220039("Book", "C# Object Oriented Solution", "300");
            DVD_714220039 product2 = new DVD_714220039("Eternal Sunshine of the Spotless Mind", "120 minutes");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has a duration of {2}", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}