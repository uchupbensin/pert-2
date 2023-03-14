using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            //int a = 10; // deklarasi variabel a dg nilai awal 10
            //int b = 6;  // deklarasi variabel b dg nilai 6

            Console.Write("inputkan nilai a =");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.Write("inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); // proses casting

            Console.WriteLine(); // tambahkan baris kosong

            Console.WriteLine("Hasil penambah " + a + "+" + b + "=" + Penambahan(a, b));
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey(); 
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan (int a, int b)
        {
            return a - b;
        }
        static int perkalian (int a, int b)
        {
            return a * b;
        }
        static int pembagian (int a, int b)
        {
            return a / b;
        }
    }
}
