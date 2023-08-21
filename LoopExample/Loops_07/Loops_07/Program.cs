using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int rows = matrix.GetLength(0); // Matrisin satır sayısı
            int cols = matrix.GetLength(1); // Matrisin sütun sayısı

            int[] rowSum = new int[rows]; // Satır toplamlarını tutan dizi
            int[] colSum = new int[cols]; // Sütun toplamlarını tutan dizi

            // Satır toplamlarını hesapla
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rowSum[i] += matrix[i, j]; // i. satırın j. elemanını toplama ekle
                }
            }

            // Sütun toplamlarını hesapla
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    colSum[j] += matrix[i, j]; // j. sütunun i. elemanını toplama ekle
                }
            }

            // Sonuçları yazdır
            Console.WriteLine("Satır Toplamları:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("Satır " + (i + 1) + " Toplamı: " + rowSum[i]);
            }

            Console.WriteLine("Sütun Toplamları:");
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Sütun " + (j + 1) + " Toplamı: " + colSum[j]);
            }

            Console.ReadLine();
        }
    }
}
