using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714220039
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("==========================================");
                Console.WriteLine("*    Membuat Index Prestasi Mahasiswa    *");
                Console.WriteLine("==========================================");

                Console.WriteLine("Masukkan Nama Mahasiswa");
                string nama_mhs = Console.ReadLine();

                Console.WriteLine("Masukkan Nilai Mahasiswa");
                int nilai_mhs = Convert.ToInt16(Console.ReadLine());

                string[] grade = { "A", "B", "C", "D" };

                if (nilai_mhs >= 85)
                {
                    Console.WriteLine("Index Nilai Sdr/i {0} adalah {1}", nama_mhs, grade[0]);
                }
                else if (nilai_mhs >= 70 && nilai_mhs < 85)
                {
                    Console.WriteLine("Index Nilai Sdr/i {0} adalah {1}", nama_mhs, grade[1]);
                }
                else if (nilai_mhs >= 60 && nilai_mhs < 75)
                {
                    Console.WriteLine("Index Nilai Sdr/i {0} adalah {1}", nama_mhs, grade[2]);
                }
                else
                {
                    Console.WriteLine("Index Nilai Sdr/i {0} adalah {1}", nama_mhs, grade[3]);
                }
                Console.WriteLine("Masukkan Indeks yang ditampilkan:");
                char index_mhs = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Sdr/i. {0} memiliki perstasi yang:", nama_mhs);
                IndexPrestasi(index_mhs);
                Console.WriteLine("Ulangi proses? Y/N");
            } while (Console.ReadLine() == "Y");
        }

        private static void IndexPrestasi(char index_mhs)
        {
            switch (index_mhs)
            {
                case 'A':
                    Console.WriteLine("Sangat Baik");
                    break;
                case 'B':
                    Console.WriteLine("Baik");
                    break;
                case 'C':
                    Console.WriteLine("Cukup");
                    break;
                case 'D':
                    Console.WriteLine("Buruk");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}