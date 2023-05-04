using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih menu calculator\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("\nInput nomor menu [1..4] : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            // Input


            //output
            if (c == 1)
            {
                Console.Write("\nInput Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil {0} + {1} = {2}", a, b, Penambahan(a, b));
            }
            else if (c == 2)
            {
                Console.Write("\nInput Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (c == 3)
            {
                Console.Write("\nInput Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (c == 4)
            {
                Console.Write("\nInput Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");

            }

            Console.WriteLine("\nTekan Sembarang key untuk keluar");
            Console.ReadKey();

        }

        // Method
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}