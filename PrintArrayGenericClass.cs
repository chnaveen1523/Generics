using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class PrintArrayGenericClass<E>
    {
        public E[] array;
        public PrintArrayGenericClass(E[] array)
        {
            this.array = array;
        }

        public void ToPrint()
        {
            Console.WriteLine("Displaying array elements");
            foreach (var element in array)
            {
                Console.WriteLine(element + "\t");
            }
        }
    }
}
© 2021 GitHub, Inc.