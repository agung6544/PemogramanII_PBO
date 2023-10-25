using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220039
{
    public class Tanaman
    {
        public string Nama { get; set; }
        public string Warna { get; set; }

        public Tanaman(string nama, string warna)
        {
            Nama = nama;
            Warna = warna;
        }
        public virtual void Tumbuh()
        {
            Console.WriteLine($"Tanaman {Nama} sedang tumbuh.");
        }
    }
}