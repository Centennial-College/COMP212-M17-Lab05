using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kevin_Ma_Lab05_Ex04
{
    /// <summary>
    /// Write a console app that makes use of generic SortedDictionary data stucture (refer to code examples from lab) to maintain the list of employees
    /// (add at least 5, you need to create a Employee class (Employee.cs - with properties Name, Salary (type-double) and appropiate constructors
    /// and overriding the ToString()). and demonstrate the use of following operations on the above employee Sorted Dictionary list.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, Employee> employeesDictionary = new SortedDictionary<int, Employee>();

            Console.WriteLine("Creating empty SortedDictionary container");
            PrintDictionary(employeesDictionary);

            Employee[] employees = new Employee[]
            {
                new Employee("Bob",12345.12),
                new Employee("Alicia",34511.88),
                new Employee("Susan",50000),
                new Employee("Paul",1000000),
                new Employee("Christiano",5213211.95),
                new Employee("Roberto",25321.44)
            };

            Console.WriteLine("Adding 6 employees to the SortedDictionary");

            for (int i = 0; i < employees.Length; i++)
            {
                AddDictionaryItem(employeesDictionary, employees[i]);
            }
            PrintDictionary(employeesDictionary);

            Console.WriteLine("Removing an employee from the SortedDictionary");
            RemoveDictionaryItem(employeesDictionary, employees[0]);
            PrintDictionary(employeesDictionary);

            /*
            Console.WriteLine("Searching for a student in the LinkedList");
            Student foundStudent = SearchLinkedListItem(lnkStudent, students[2]).Value;
            Console.Write($"The student with '{students[2]}' was ");
            if (foundStudent == null)
                Console.Write(" not ");
            Console.WriteLine("found in the LinkedList.");

            if (SearchLinkedListItem(lnkStudent, new Student(22, "Michelle")) != null)
            {
                foundStudent = SearchLinkedListItem(lnkStudent, new Student(22, "Michelle")).Value;
            }
            else
            {
                foundStudent = null;
            }
            Console.Write($"The student with 'ID: 33 Name: Michelle' was ");
            if (foundStudent == null)
                Console.Write(" not ");
            Console.WriteLine("found in the LinkedList.");
            Console.WriteLine();

            Console.WriteLine("Clearing the linked list");
            RemoveAllLinkedListItems(lnkStudent);
            PrintLinkedList(lnkStudent);
            */
        }

        //adding an item to the sorted dictionary
        private static void AddDictionaryItem(SortedDictionary<int, Employee> var, Employee emp)
        {
            var.Add(emp.Id, emp);
        }

        //removing an item from dictionary
        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> var, Employee emp)
        {
            var.Remove(emp.Id);
        }

        //displaying all employees in the sorted dictioanry
        private static void PrintDictionary(SortedDictionary<int, Employee> var)
        {
            if (var.Count == 0)
                Console.WriteLine("Empty SortedDictionary");

            else
            {
                foreach (var item in var.Values)
                {
                    Console.WriteLine($"{item.ToString()} ");
                }
            }
            Console.WriteLine();
        }

        //searching for an employee based on employee id
        private static Employee SearchDictionaryItem(SortedDictionary<int, Employee> var, int empId)
        {
            return var[empId] == null ? null : var[empId];
        }

        //finding an emp with highest salary
        private static Employee MaxDictionaryItem(SortedDictionary<int, Employee> var)
        {
            Employee highestPaidEmp = var[0];
            for (int i = 0; i < var.Count; i++)
            {
                if (var[i].Salary > highestPaidEmp.Salary)
                    highestPaidEmp = var[i];
            }

            return highestPaidEmp;
        }
    }
}
