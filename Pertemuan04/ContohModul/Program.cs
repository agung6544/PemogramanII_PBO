using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cntoh
{
    public class Program
    {
        public void Tes(string a, int b)
        {
            Console.WriteLine("tes");
        }

        static void Main(string[] args)
        {
            Mobil SuatuMobil = new Mobil();
            Mobil MobilSaya = new Mobil()
            {
                nama = "McLaren",
                kecepatan = 10,
                bensin = 3000,
                posisi = 0

            };
            MobilSaya.maju();
            Console.WriteLine(SuatuMobil.nama);
            Console.Write(SuatuMobil);

            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin);

            Mobil MobilAnda = new Mobil("Suxuru", 300, 500);

            MobilAnda.percepat();
            Console.WriteLine(MobilAnda.nama);
            Console.WriteLine(MobilAnda.kecepatan);
            Console.WriteLine(MobilAnda.bensin);

            FieldPropherty p = new FieldPropherty();
            p.Materi = "Bahasa Pemograman C#";
            Console.WriteLine(p.Materi);

            FieldPropherty.Person x = new FieldPropherty.Person();
            x.Nilai = 20;
            Console.WriteLine(x.Nilai);

            Civic c = new Civic();
            Console.WriteLine(c.Roda);
            c.Klakson();

            Bentuk.Lingkaran a = new Bentuk.Lingkaran();
            a.Gambar();

            Bentuk.Persegi b = new Bentuk.Persegi();
            b.Gambar();
        }
    }
}
