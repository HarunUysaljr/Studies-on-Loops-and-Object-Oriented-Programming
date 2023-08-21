using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sayı : ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("üst gir");
            int ust = int.Parse(Console.ReadLine());

            int sonuc = 1;

            for (int i = 0; i <= ust; i++)
            {
                sonuc *= number;
            }
            Console.WriteLine($"taban sayısı {number}, girilen üst {ust} sonuc{sonuc}");

            Console.ReadLine();
        }

        
    }
}
