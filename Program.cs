using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //To take userinput
            //Console.WriteLine("Please enter number of elements need to add into integer array");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] intArray = new int[n];
            //for(int i=0;i<n;i++)
            //{
            //    intArray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //PrintArray.ToPrint(intArray);

            int[] intArray = { 20, 25, 10, 5, 4 };
            PrintArray.ToPrint(intArray);
            Console.ReadLine();
        }
    }
}