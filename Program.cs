using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAverage
{
    internal class Program
    {
       static void Main(string[] args)
        {
            int[] A = new int[10];
            int total = 0,average=0;
            Console.WriteLine("Enter elements:(Ranging from 1 to 50!)");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                A[i] = Convert.ToInt32(Console.ReadLine());
                total += A[i];
            }
            average = total / A.Length;
            Console.WriteLine("The average of elements of thee given array is {0}.", average);
        }
    }
}
