using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cntoh
{
    internal class Inheritance
    {
    }

    public class Car
    {
        public void Klakson()
        {
            Console.WriteLine("Biiimmmm!!!");
        }
        public int Roda { get; set; }
        public int Tahun { get; set; }
    }

    class Civic : Car
    {
        public Civic()
        {
            Roda = 4;
        }
    }
}
