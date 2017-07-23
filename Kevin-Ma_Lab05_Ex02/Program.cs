using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin_Ma_Lab05_Ex02
{
    class Program
    {
        /// <summary>
        /// Overload a generic method DisplayArray of the class/lab example so that it takes two additional int arguments: low index and high index.
        /// A call to this method displays only the designated portion of the array. Validate lowindex and highindex. If either is out of range, or if
        /// higherIndex is less than or equal to lowIndex, the overloaded displayArray method should throw an ArgumentException; otherwise, DisplayArray
        /// should return the number of elements displayed. Then modify Main to exercise both versions of DisplayArray on arrays intArray, doubleArray
        /// and charArray. Test all capabilities of both versions of DisplayArray.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //FROM THE CLASS EXAMPLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // create arrays of int, double and char
            int[] intArray = { 17, 12, 3, 40, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument
        }

        //FROM THE CLASS EXAMPLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // output array of all types                           
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}
