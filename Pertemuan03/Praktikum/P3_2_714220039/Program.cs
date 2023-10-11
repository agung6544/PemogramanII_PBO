using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220039
{
    class Program
    {
        static void Main()
        {
            bool ulang = true;

            while (ulang)
            {
                Console.Clear();

                Console.WriteLine("ANAK AYAM TURUN");
                string nilai_n_str = Console.ReadLine();

                if (int.TryParse(nilai_n_str, out int nilai_n) && nilai_n >= 1 && nilai_n <= 10)
                {
                    int nilai_b = nilai_n - 1;

                    for (int i = nilai_n; i >= 1; i--)
                    {
                        if (i == 1)
                            Console.WriteLine("Anak Ayam Turunlah {0}, mati satu tinggallah induknya", i);
                        else
                            Console.WriteLine("Anak Ayam Turunlah {0}, mati satu tinggallah {1}", i, i - 1);
                    }
                }
                else
                {
                    Console.WriteLine("Nilai Tidak Boleh Kurang dari 1 atau Lebih dari 10");
                }

                Console.Write("Lanjut bersyair? (ya/tidak): ");
                string jawaban = Console.ReadLine().ToLower();

                ulang = (jawaban == "ya");
            }
        }
    }
}


