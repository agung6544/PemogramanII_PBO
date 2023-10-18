using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cntoh
{
    internal class Polymorphism
    {
    }
    public class Bentuk
    {
        public virtual void Gambar()
        {
            Console.Write("Ini adalah Base Class Bentuk");
        }
    public class Lingkaran : Bentuk 
        {
            public override void Gambar()
            {
                Console.WriteLine("Menggambar Lingkaran");
            }
        }
    public class Persegi : Bentuk
        {
            public override void Gambar()
            {
                Console.WriteLine("Menggambar persegi");
            }
        }
    }
}
