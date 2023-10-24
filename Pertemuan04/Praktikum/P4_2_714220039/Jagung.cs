using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220039
{
    class Jagung : Tanaman
    {
        public double Tinggi { get; set; }

        public Jagung(string nama, string warna, double tinggi) : base(nama, warna)
        {
            Tinggi = tinggi;
        }
        public override void Tumbuh()
        {
            Console.WriteLine($"Jagung {Nama} dengan tinggi {Tinggi} cm sedang tumbuh.");
        }
    }
}
