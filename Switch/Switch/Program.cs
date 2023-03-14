using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ini apps sederhana mengguanakan ";
            Console.Write("Operasi apa yang ingin diterjemahkan \n 1. '+' \n 2. '-' \n 3. 'x' \n 4. '/' \n : ");
            char Operasi = char.Parse(Console.ReadLine());

            if(Operasi != '+' && Operasi != '-' && Operasi != 'x' && Operasi != '/')
            {
                Console.WriteLine("Operasi yang anda masukan tidak tersedia");
                return;
            } else
            switch(Operasi)
            {
                case '+':
                    Console.WriteLine("Operasi penjumlahan");
                    break;
                case '-':
                    Console.WriteLine("Operasi pengurangan");
                    break;
                case 'x':
                    Console.WriteLine("Operasi perkalian");
                    break;
                case '/':
                    Console.WriteLine("Operasi pembagian");
                    break;
            }
            Console.ReadLine();
        }
        
    }
}
