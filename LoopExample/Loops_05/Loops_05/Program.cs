using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //fibo
            Console.WriteLine("Fib boyutu");
            int Fib = int.Parse(Console.ReadLine());

            int x = 0;
            int y = 1;

            for (int i = 2; i < Fib; i++)
            {
                int z = x + y;
                Console.WriteLine(""+z);
                x = y;
                y = z;
            }
            Console.ReadLine();
        }
    }
}
