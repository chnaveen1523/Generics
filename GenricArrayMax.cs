using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{/// <summary>
///Finding maximum from a aaray
/// </summary>
/// <typeparam name="T"></typeparam>
    class GenericArrayMax<T> where T : IComparable
    {
        public T[] array;
        public GenericArrayMax(T[] array)
        {
            this.array = array;
        }
        /// <summary>
        /// Sorts the specified values.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        /// <summary>
        /// Retun the Maximum value.
        /// </summary>
        /// <param name="Values">The values.</param>
        /// <returns></returns>
        public T MaxValue(params T[] Values)
        {
            T[] sortedArray = Sort(this.array);
            return sortedArray[sortedArray.Length - 1];
        }
        /// <summary>
        /// Prints the maximum.
        /// </summary>
        public void PrintMax()
        {
            var max = MaxValue(this.array);
            Console.WriteLine("The maximum value is:" + max);
        }
    }
}