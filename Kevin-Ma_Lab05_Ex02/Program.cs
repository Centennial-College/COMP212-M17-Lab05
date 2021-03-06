﻿using System;
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

            Console.WriteLine("==================================================================================================");
            Console.WriteLine("COMP212-M17 Lab05 Exercise #2");
            Console.WriteLine("==================================================================================================");

            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument

            Console.WriteLine("\nOverloaded method demo below...\n");

            //NEW CODE I ADDED+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.WriteLine("VALID Inputs");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            //tested middle section
            Console.Write("Displaying intArray from index 2 to 5 (non-inclusive): ");
            Console.WriteLine($"{DisplayArray(intArray, 2, 5)} elements were displayed"); // pass an int array argument to the overloaded method
            Console.WriteLine();

            //tested starting boundary
            Console.Write("Displaying doubleArray from index 0 to 4 (non-inclusive): ");
            Console.WriteLine($"{DisplayArray(doubleArray, 0, 4)} elements were displayed"); // pass a double array argument to the overloaded method
            Console.WriteLine();

            //tested end boundary
            Console.Write("Displaying charArray from index 3 to charArray.Length (non-inclusive): ");
            Console.WriteLine($"{DisplayArray(charArray, 3, charArray.Length)} elements were displayed"); // pass a char array argument to the overloaded method
            Console.WriteLine();

            //INVALID Inputs
            Console.WriteLine("INVALID Inputs");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            try
            {
                //lowIndex out of bounds
                Console.Write("Displaying intArray from index -2 to 5 (non-inclusive): ");
                Console.WriteLine($"{DisplayArray(intArray, -2, 5)} elements were displayed"); // pass an int array argument to the                 overloaded method

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\n" + e.Message);
            }
            Console.WriteLine();

            try
            {
                //highIndex out of bounds
                Console.Write("Displaying doubleArray from index 3 to 50 (non-inclusive): ");
                Console.WriteLine($"{DisplayArray(doubleArray, 3, 50)} elements were displayed"); // pass a double array argument to the                 overloaded method
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\n" + e.Message);
            }
            Console.WriteLine();

            try
            {
                //highIndex <= lowIndex
                Console.Write("Displaying charArray from index 4 to 3 (non-inclusive): ");
                Console.WriteLine($"{DisplayArray(charArray, 4, 3)} elements were displayed"); // pass a char array argument to the                 overloaded method
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\n" + e.Message);
            }

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

        //NEW CODE I ADDED+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// This method displays only the designated portion of the array (starting at lowIndex, up to but non-inclusive of highIndex)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputArray"></param>
        /// <param name="lowIndex"></param>
        /// <param name="highIndex"></param>
        /// <returns>
        ///     the number of elements displayed
        /// </returns>
        private static int DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
        {
            //validate lowIndex and highIndex
            //if either is out of range,
            //or high is <= low, throw ArgumentException
            if (
                    lowIndex < 0 || lowIndex > inputArray.Length ||
                    highIndex < 0 || highIndex > inputArray.Length ||
                    highIndex <= lowIndex
                )
            {
                throw new ArgumentException("***Invalid arguments - either one of the indices are out of bounds or highIndex is less than or equal to lowIndex.");
            }

            //valid input, so display designated portion of the array
            for (int i = lowIndex; i < highIndex; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }
            Console.WriteLine();

            //return the number of elements displayed
            return highIndex - lowIndex;
        }
    }
}
