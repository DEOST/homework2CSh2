using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MethodArrayBinarySearch
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);

            int numIndex = Array.BinarySearch(array, k);
            while (numIndex < 0)
            {
                if (k < array[0])
                {
                    break;
                }
                k--;
                numIndex = Array.BinarySearch(array, k);

            }
            if (numIndex < 0)
            {
                Console.WriteLine("Searching number not found!");
            }
            else
            {
                Console.WriteLine("Number <= K found at index [{0}] = {1}", numIndex, array[numIndex]);
            }
        }
    }
}
