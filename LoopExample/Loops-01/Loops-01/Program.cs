using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;

            for (int i = 0; i <= 10; i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
