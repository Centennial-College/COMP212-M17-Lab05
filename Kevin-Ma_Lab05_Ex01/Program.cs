using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// @Name           Generic Linear Search Method
/// @Author         Kevin Ma
/// @Date           July 22, 2017
/// @Description    Write a generic method, Search, that searches an array using the linear-search algorithm. Method Search should compare the
///                 search key with each element in its array parameter until the search key is found or until the end of the array is reached.
///                 If the search key is found, return its location in the array; otherwise return -1. Write a win form test app that inputs and
///                 searches an int array and a double array. Provide buttons that the user can click to randomly generate int and double values.
///                 Display the generated values in a TextBox, so the user knows what values they can search for [Hint: Use(T: IComparable<T>) in 
///                 the where clause for the method Search so that you can use method CompareTo to compare the search key to the elements in the
///                 array.]
/// </summary>
namespace Kevin_Ma_Lab05_Ex01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GenericLinearSearchMethodTestForm());
        }

        //Create windows form. Two buttons, RNG to generate double list, RNG to generate int array.
    }
}
