//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SquareSumInMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int bestSum = int.MinValue;
            int sum = 0;
            int bestX = 0;
            int bestY = 0;
      /*      n=5; m=4;
              int[,] matrix = {
              {5, 7, 9,1},
              {21, 15, 3, 20},
              {-5, 8, -15, 0}, 
             {7, 1, 51, 100},
              {1, 17, 2, -20} 
                        };
*/
                        for (int row = 0; row < n; row++)
                       {
                           for (int col = 0; col < m; col++)
                           {
                               Console.Write("m [{0},{1}] = ", row, col);
                               matrix[row, col] = int.Parse(Console.ReadLine());
                           }
                       }
           
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < m - 2; col++)
                {
                    sum = 0;
                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            sum += matrix[i, j];
                        }
                    }


                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestX = row;
                        bestY = col;
                    }
                }
            }

            for (int row1 = 0; row1 < n; row1++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0,4}", matrix[row1, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Best sum is {0}, x= {1}, y = {2}", bestSum, bestX, bestY);
            for (int i = bestX; i < bestX + 3; i++)
            {
                for (int j = bestY; j < bestY + 3; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

