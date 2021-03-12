using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorApp
{
    class Program
    {
        static int tambah(int a, int b)
        {
            return (a + b);
        }
        static int kurang(int a, int b)
        {
            return (a - b);
        }
        static int kali(int a, int b)
        {
            return (a * b);
        }
        static int bagi(int a, int b)
        {
            return (a / b);
        }
        static void Main(string[] args)
        {
            Console.Title = " ** Apliaksi Calculator ** ";
            int bil1, bil2;
            char pilihan;
            Console.WriteLine("Pilih menu calculator\n");
            Console.WriteLine("============================\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");
            Console.Write("Masukkan pilihan [1..4] : ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == '1')
            {
                Console.Write("Masukkan Bilangan Pertama   : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukkan Bilangan Kedua     : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Penambahan            : {0} + {1} = {2} ", bil1, bil1, tambah(bil1, bil2));
            }
            else if (pilihan == '2')
            {
                Console.Write("Masukkan Bilangan Pertama   : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukkan Bilangan Kedua     : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Pengurangan           : {0} - {1} = {2} ", bil1, bil2, kurang(bil1, bil2));
            }
            else if (pilihan == '3')
            {
                Console.Write("Masukkan Bilangan Pertama   : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukkan Bilangan Kedua     : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Perkalian             : {0} * {1} = {2} ", bil1, bil2, kali(bil1, bil2));
            }
            else if (pilihan == '4')
            {
                Console.Write("Masukkan Bilangan Pertama   : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukkan Bilangan Kedua     : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Pembagian             : {0} / {1} ={2} ", bil1, bil2, bagi(bil1, bil2));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}
