using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            double tambah = angka1 + angka2;
            double kurang = angka1 - angka2;
            double kali = angka1 * angka2;

            // Menghindari pembagian oleh nol
            double bagi = (angka2 != 0) ? angka1 / angka2 : 0;

            Console.WriteLine("{0} + {1} = {2}",angka1,angka2, tambah);
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, kurang);
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, kali);
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, bagi);
        }
    }
}
