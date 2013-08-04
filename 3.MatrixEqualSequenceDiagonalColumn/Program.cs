//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, 
//column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MatrixEqualSequenceDiagonalColumn
{
    class Program
    {
        static void Main()
        {
            //  Console.Write("n = ");
            //  int n = int.Parse(Console.ReadLine());
            // Console.Write("m = ");
            // int m = int.Parse(Console.ReadLine());
            int n = 3; int m = 4;
            string[,] matrix = new string[n, m];

          matrix = new string[,] {
                  {"ha","xx","ha","hi"},
                  {"fo","ha","x","ho"},
                  {"ha","o","hi","xx"} 
                            };
            //matrix = new string[,] { 
           //{ "s", "qq", "s" }, 
           //{ "pp", "pp", "s" }, 
           //{ "pp", "qq", "s" } };

            //matrix = new string[,] {
            //{ "pop", "trip", "hop", "trop" }, 
            //{ "ha", "hi", "trop", "hi" }, 
            //{ "ho", "trop", "he", "ha" }, 
            //{ "trop", "hum", "hum", "hum" }};

         // matrix = new string[,] { 
         // { "pop", "pop", "ha", "ha" }, 
         // { "pop", "pop", "ha", "hi" }, 
         // { "pop", "ha", "pop", "hi" }, 
         // { "ha", "hi", "hi", "pop" } };
            int bestLengthHor = 1;
            int lengthHor = 1;
            string longestStrHor="";
            int bestLengthVer = 1;
            int lengthVer = 1;
            string longestStrVer = "";
            int bestLengthDiagL = 1;
            int lengthDiagL = 1;
            string longestStrDiagL = "";
            int bestLengthDiagR = 1;
            int lengthDiagR = 1;
            string longestStrDiagR = "";
            //          for (int row = 0; row < n; row++)
            //          {
            //              for (int col = 0; col < m; col++)
            //              {
            //                  matrix[row, col] = Console.ReadLine();
            //              }
            //          }
            
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (col<m-1)//Horizontal Check
                    {
                        if (matrix[row, col] == matrix[row, (col + 1)])
                        {
                            lengthHor++;
                        }
                        else
                        {
                            lengthHor = 1;
                        }
                        if (bestLengthHor < lengthHor)
                        {
                            bestLengthHor = lengthHor;
                            longestStrHor = matrix[row, col];
                           
                        }
                    }
                    if (row < n - 1)//Vertical Check
                    {
                        if (matrix[row, col] == matrix[(row+1), col])
                        {
                            lengthVer++;
                        }
                        else
                        {
                            lengthVer = 1;
                        }
                        if (bestLengthVer < lengthVer)
                        {
                            bestLengthVer = lengthVer;
                            longestStrVer = matrix[row, col];
                           
                        }
                    }
                    if (row < n - 1 && col<m-1)//diagonal Check
                    {
                       if (matrix[row, col] == matrix[(row + 1), (col + 1)]) //Left Top -Right Down
                       {
                           lengthDiagL++;
                       }
                       else
                       {
                           lengthDiagL = 1;
                       }
                       if (bestLengthDiagL < lengthDiagL)
                       {
                           bestLengthDiagL = lengthDiagL;
                           if (bestLengthDiagL>1&&col>0&&row>0)
                           {
                               longestStrDiagL = matrix[row-1, col-1];
                           }
                           else
                               longestStrDiagL = matrix[row , col];
                       }
                       if (col>0)
                       {
                           if (matrix[row, col] == matrix[(row + 1), (col - 1)]) //Right Top - Left Down
                        {
                            lengthDiagR++;
                        }
                        else
                        {
                            lengthDiagR = 1;
                        }
                        if (bestLengthDiagR < lengthDiagR)
                        {
                            bestLengthDiagR = lengthDiagR;
                            if (bestLengthDiagR > 1 && col > 0 && row > 0)
                            {
                                longestStrDiagR = matrix[row - 1, col - 1];
                            }
                            else
                                longestStrDiagR = matrix[row, col];
                        }
                        
                        }
                        if (col == 0 && row > 0 && longestStrDiagR==matrix[row,col])
                        {
                            bestLengthDiagR++;
                        }
                    }
                }
                lengthHor = 1;
                lengthVer = 1;
                lengthDiagL = 1;
                lengthDiagR = 1;
            }
            
            Console.WriteLine("Longest horizontal is {0} with {1} repetitions ", longestStrHor, bestLengthHor);
            Console.WriteLine("Longest vertical is {0} with {1} repetitions ", longestStrVer, bestLengthVer);
            Console.WriteLine("Longest diagonal Left Top -Right Down is {0} with {1} repetitions ", longestStrDiagL, bestLengthDiagL);
            Console.WriteLine("Longest diagonal Right Top - Left Down is {0} with {1} repetitions ", longestStrDiagR, bestLengthDiagR);
        }
        
    }
}
