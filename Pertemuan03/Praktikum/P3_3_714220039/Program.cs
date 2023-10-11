using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220039
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ulang = true;

            while (ulang)
            {
                Console.WriteLine("MENU PERSEGI PANJANG :");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.Write("Pilih menu (1/2): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("MENGHITUNG LUAS PERSEGI PANJANG");
                        HitungLuasPersegiPanjang();
                        break;

                    case "2":
                        Console.WriteLine("MENGHITUNG KELILING PERSEGI PANJANG");
                        HitungKelilingPersegiPanjang();
                        break;

                    default:
                        Console.WriteLine("Menu tidak tersedia.");
                        break;
                }

                Console.Write("Ingin mengulang kembali? (Y/N): ");
                string jawaban = Console.ReadLine().ToUpper();

                ulang = (jawaban == "Y");
            }
        }

        static void HitungLuasPersegiPanjang()
        {
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;
            Console.WriteLine("Luas persegi panjang = " + luas);
        }

        static void HitungKelilingPersegiPanjang()
        {
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double keliling = 2 * (panjang + lebar);
            Console.WriteLine("Keliling persegi panjang = " + keliling);
        }
    }
}
