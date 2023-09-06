using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sorting_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 5, 9, 3, 5, 7, 6, 5, 4, 8, 5, 2 };
            int[] Sorted = BubbleSorting(ints, 12);
            for(int i =  0; i < Sorted.Length; i++)
            {
                Console.WriteLine(Sorted[i]);
            }
            Console.ReadLine();
        }
        public static int[] BubbleSorting(int[] A , int N)
        {
            for(int pass = N-1; pass >= 0; pass--)
            {
                for(int i = 0; i < pass; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
            return A;

        }
    }
}
