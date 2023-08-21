using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yıldız boyutu");
            int kulNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < kulNumber; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
