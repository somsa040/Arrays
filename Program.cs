using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo3_FA_2017
    {
        class Program
        {
            static void Main(string[] args)
            {
                //create an array
                //data type[] identifier = new string[n]; or 
                //data type[] identifier = ""; or
                //data type[] identifier = "item1,item2,item3"
                string[] items = new string[5];

                //Ask user for input
                Console.WriteLine("What is the first item in your grocery list:");

                //store result in index position 0
                items[0] = Console.ReadLine();

                Console.WriteLine("What is the second item in your grocery list:");
                items[1] = Console.ReadLine();

                Console.WriteLine("\nWhat is the third item in your grocery list:");
                items[2] = Console.ReadLine();

                Console.WriteLine("\nWhat is the fourth item in your grocery list:");
                items[3] = Console.ReadLine();

                Console.WriteLine("\nWhat is the fifth item in your grocery list:");
                items[4] = Console.ReadLine();

                //clear the console
                Console.Clear();

                //print out the grocery list items one by one using array position indexes
                Console.WriteLine("Items on my grocery list include:\n");
                Console.WriteLine(items[0]);
                Console.WriteLine(items[1]);
                Console.WriteLine(items[2]);
                Console.WriteLine(items[3]);
                Console.WriteLine(items[4]);

                Console.ReadLine();

                //print out the grocery list items one by one using array position indexes
                Console.WriteLine("Items on my grocery list include:\n");
                Console.WriteLine("Index position 0: " + items[0]);
                Console.WriteLine("Index position 1: " + items[1]);
                Console.WriteLine("Index position 2: " + items[2]);
                Console.WriteLine("Index position 3: " + items[3]);
                Console.WriteLine("Index position 4: " + items[4]);

                Console.ReadLine();

            foreach (string s in items)
            {
                Console.WriteLine(s);

            }

            Console.ReadLine();

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Index position " + i + ": " + items[i]);
            }

            Console.ReadLine();

        }
        }
    }
