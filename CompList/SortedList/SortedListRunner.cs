using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompList.SortedList
{
    internal class SortedListRunner
    {
        static void Main(string[] args)
        {
            SortedList<int, string> numbers = new SortedList<int, string>();
            numbers.Add(7, "Seven");
            numbers.Add(4, "four");
            numbers.Add(2, "two");
            numbers.Add(8, "eight");
            numbers.Add(9, "nine");

            DisplayElements(numbers);
            //remove 1 
            numbers.Remove(4);
            DisplayElements(numbers);
            //remove element at index 2
            numbers.RemoveAt(2);
            DisplayElements(numbers);

            /*C a sorted list to store departments
             * with a list of employees per department*/


            SortedList<String,List<string>> department = new SortedList<string, List<string>>();
            department.Add("IT", new List<string>() { "Brock Lesnar", "John Cena", "Kurt Angle" });
            department.Add("Finanace", new List<string>() { "Chris", "Jabulani", "Anthony" });
            department.Add("HR", new List<string>() { "Lindsay" });
            DisplayEmployees(department);
            Console.ReadLine();
        }

        public static void DisplayElements(SortedList<int, string>numbers)
        {

           foreach (KeyValuePair<int,string> num in numbers) 
            {
                Console.WriteLine(num.Key + " - " + num.Value);
            }
            Console.WriteLine("=============================");

         

        }

        public static void DisplayEmployees(SortedList<String, List<string>> department)
        {
           foreach (KeyValuePair<String, List<string>> dep in department)
            {
                Console.Write(dep.Key);
              foreach (String e in dep.Value)
                {
                    Console.WriteLine($"\t{e}");
                }
            }
            Console.WriteLine("=============================");

        }
    }
}
