using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JagedArray
{
    class Program
    {
        static void Main(string[] args)
        {
                // Single-dimensional array
                int[] numbers = new int[5];

                // Multidimensional array
                string[,] names = new string[5, 4];

                // Array-of-arrays (jagged array)
                byte[][] scores = new byte[5][];

                // Create the jagged array
                for (int i = 0; i < scores.Length; i++)
                {
                    scores[i] = new byte[i + 3];
                }

                // Print length of each row
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
                }


         
            int[][] scores2 = new int[5][] { new int[] { 2, 3, 3, 4, 6, 7, 4 }, new int[] { 5, 6, 2, 3, 3, 6, 2 }, new int[] { 2, 3, 3, 4, 6, 7, 4 }, new int[] { 5, 6, 2, 3, 3, 6, 2 } , new int[] { 2, 3, 3, 4, 6, 7, 4 }};

            for (int i = 0; i < scores2.Length; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                     
                        Console.Write(scores2[i][j]);
                    }
                Console.WriteLine();

            }

            Console.ReadLine();
          }
     }
}
