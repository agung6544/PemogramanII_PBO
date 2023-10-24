using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220039
{
    internal class Program_sawah
    {
        static void Main(string[] args)
        {
            Tanaman tanaman1 = new Padi("Padi Biasa", "Hijau", 150);
            Tanaman tanaman2 = new Jagung("Jagung Manis", "Kuning", 100);

            Console.WriteLine("Sawah:");
            Console.WriteLine("=============");
            tanaman1.Tumbuh();
            tanaman2.Tumbuh();
        }
    }
}
