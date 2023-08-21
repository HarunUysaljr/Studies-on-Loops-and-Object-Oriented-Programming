using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı :");
            int kul = Convert.ToInt32(Console.ReadLine());

            int fakt=1;
            for (int i = 1; i <= kul; i++)
            {
                fakt *= i;
            }

            Console.WriteLine($"{kul}! = {fakt}");
            Console.ReadLine();
        }
    }
}
