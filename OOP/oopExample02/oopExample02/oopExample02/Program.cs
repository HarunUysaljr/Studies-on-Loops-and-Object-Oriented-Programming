using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            var name = Console.ReadLine();

            if (name== string.Empty)
            {
                name = "no name";
            }

            Console.WriteLine("Welcome {0} to your oop adventure!", name);


            Console.ReadLine();
        }
    }
}
