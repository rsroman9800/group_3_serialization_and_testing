using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLL list = new SLL();

            Console.WriteLine("Is list empty? " + list.IsEmpty());

            list.Append("First");
            list.Append("Second");
            list.Prepend("Zero");

            Console.WriteLine("List size: " + list.Size());

            Console.WriteLine("Element at index 1: " + list.Retrieve(1));

            list.Insert("Inserted", 1);

            Console.WriteLine("Element at index 1 after insert: " + list.Retrieve(1));

            list.Replace("Replaced", 1);

            Console.WriteLine("Element at index 1 after replace: " + list.Retrieve(1));

            Console.WriteLine("Index of 'Second': " + list.IndexOf("Second"));

            Console.WriteLine("Does list contain 'Zero'? " + list.Contains("Zero"));

            list.Delete(1);

            Console.WriteLine("Element at index 1 after delete: " + list.Retrieve(1));

            list.Clear();

            Console.WriteLine("Is list empty after clear? " + list.IsEmpty());


            Console.ReadLine();
        }
    }
}
