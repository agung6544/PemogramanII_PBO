using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220039
{
    public class Padi : Tanaman
    {
        public int JumlahBulir { get; set; }

        public Padi(string nama, string warna, int jumlahBulir) : base(nama, warna)
        {
            JumlahBulir = jumlahBulir;
        }
        public override void Tumbuh()
        {
            Console.WriteLine($"Padi {Nama} dengan {JumlahBulir} bulir sedang tumbuh.");
        }
    }
}
