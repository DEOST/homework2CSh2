//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2CSh2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] firstMatrix = new  int[n,n];
            for (int row = 0; row < n; row++)
            {
                int num = row +1;
                for (int col = 0; col < n; col++)
                {
                    firstMatrix[row, col] = num;
                    Console.Write("{0,4}",firstMatrix[row, col]);
                    num += n;
                }
                Console.WriteLine();
            }
            //second matrix
            int[,] secondMatrix = new int[n, n];
            Console.WriteLine();
            int counter =1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        secondMatrix[row, col] = counter++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        secondMatrix[row, col] = counter++;
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", secondMatrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //third matrix
            int[,] thirdMatrix = new int[n, n];
            
            int fill=1;
            for (int diagonal= 0; diagonal < (n * 2) - 1; diagonal++)
            {
                int row = n - 1 - diagonal;
                if (row < 0)
                {
                    row = 0;
                }
                int col = 0;
                if (diagonal >= n)
                {
                    col = diagonal - n + 1;
                }
                while ((row < n) && (col < n))
                {
                    thirdMatrix[row, col] = fill;
                    fill++;
                    row++;
                    col++;
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", thirdMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
