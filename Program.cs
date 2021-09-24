using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
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
            //PrintArray.ToPrint(intArray);
            double[] doubleArray = { 20.25, 14.25, 55.10, 6.5, 3.4 };
            //PrintArray.ToPrint(doubleArray);
            char[] charArray = { 'W', 'e', 'l', 'c', 'o', 'm', 'e' };
            //PrintArray.ToPrint(charArray);
            //PrintArrayGenericMethod.ToPrint<int>(intArray);
            //PrintArrayGenericMethod.ToPrint<double>(doubleArray);
            //PrintArrayGenericMethod.ToPrint<char>(charArray);
            //PrintArrayGenericClass<int> genericInt = new PrintArrayGenericClass<int>(intArray);
            //genericInt.ToPrint();
            //PrintArrayGenericClass<double> genericDouble = new PrintArrayGenericClass<double>(doubleArray);
            //genericDouble.ToPrint();
            //PrintArrayGenericClass<char> genericChar = new PrintArrayGenericClass<char>(charArray);
            //genericChar.ToPrint();
            //Console.WriteLine("Maximum number {0} out of {1},{2},{3}:", GenericFindMax<int>.FindMax(20, 10, 21),20,10,21);
            //Console.WriteLine("Maximum number {0}:", MaxNumber.FindMax(25f, 12f, 18f));
            //Console.WriteLine("Maximum number {0}:", MaxNumber.FindMax("hello","hel" ,"helo"));
            //Console.WriteLine("Maximum is:" +new GenericFindMax<int>(10, 15, 5).MaxNum()); 
            GenericArrayMax<int> final = new GenericArrayMax<int>(intArray);
            final.PrintMax();
            Console.ReadLine();
        }
    }
}