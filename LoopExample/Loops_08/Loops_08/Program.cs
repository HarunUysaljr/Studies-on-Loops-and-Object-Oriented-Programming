using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin girin: ");
            string input = Console.ReadLine();

            Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (characterCounts.ContainsKey(c))
                {
                    characterCounts[c]++;
                }
                else
                {
                    characterCounts[c] = 1;
                }
            }

            foreach (var pair in characterCounts)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine($"Karakter '{pair.Key}' tekrar sayısı: {pair.Value}");
                }
            }
            Console.ReadLine();
        }
    }
}
