using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo.cs
{
    class PrintArray
    {
        public static void ToPrint(int[] intArray)
        {
            foreach (int element in intArray)
            {
                Console.WriteLine(" " + element + " ");
            }
        }

        public static void ToPrint(double[] doubleArray)
        {
            foreach (double element in doubleArray)
            {
                Console.WriteLine(" " + element + " ");
            }
        }

        public static void ToPrint(char[] charArray)
        {
            foreach (char element in charArray)
            {
                Console.WriteLine(" " + element + " ");
            }
        }
    }
}