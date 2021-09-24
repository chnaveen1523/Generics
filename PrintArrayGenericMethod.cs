using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class PrintArrayGenericMethod
    {
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("Display array elements");
            foreach (var element in array)
            {
                Console.WriteLine(element + "\t");
            }
        }
    }
}