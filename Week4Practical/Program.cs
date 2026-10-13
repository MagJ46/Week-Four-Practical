using System;
using System.Collections.Generic;

namespace Week4Practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==================================================
            // Challenge 1: Using arrays and forcing errors
            // ==================================================
            Console.WriteLine("=== Challenge 1: Arrays ===");

            // Task 1: declare and initialise the array
            string[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda" };

            // Task 2: print all brands with foreach
            Console.WriteLine("Original order:");
            foreach (string manufacturer in carManufacturers)
            {
                Console.WriteLine(manufacturer);
            }

            // Task 3: sort alphabetically and print again (should begin with BMW)
            Array.Sort(carManufacturers);
            Console.WriteLine("\nSorted order:");
            foreach (string manufacturer in carManufacturers)
            {
                Console.WriteLine(manufacturer);
            }

            // Task 4 + Challenge 4 (steps 1-3): the deliberate off-by-one loop,
            // now uncommented and wrapped in try/catch/finally so it no longer crashes.
            Console.WriteLine("\nLoop with off-by-one error:");
            try
            {
                for (int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
                {
                    Console.WriteLine(carManufacturers[carIndex]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Attempted to access an array index that does not exist.");
            }
            finally
            {
                Console.WriteLine("Array processing complete.");
            }

            // ==================================================
            // Challenge 2: Dynamic lists
            // ==================================================
            Console.WriteLine("\n=== Challenge 2: Lists ===");

            // 1. Create an empty list
            List<string> months = new List<string>();

            // 2. Add all twelve months and print the count
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");
            Console.WriteLine("Month count: " + months.Count); // 12

            // 3. Remove September and November, print the count again
            months.Remove("September");
            months.Remove("November");
            Console.WriteLine("Month count after removal: " + months.Count); // 10

            // 4. Find the index of December
            int decemberIndex = months.IndexOf("December");
            Console.WriteLine("Index of December: " + decemberIndex); // 9

            // 5. Convert the list to a standard array
            string[] monthNamesArray = months.ToArray();
            Console.WriteLine("Converted to array with " + monthNamesArray.Length + " items.");

            // ==================================================
            // Challenge 3: Dictionaries and key-value pairs
            // ==================================================
            Console.WriteLine("\n=== Challenge 3: Dictionaries ===");

            // 1. Create the dictionary
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            // 2. Add three items
            inventory.Add("Health Potion", 5);
            inventory.Add("Mana Potion", 2);
            inventory.Add("Gold Coin", 100);

            // 3. Overwrite a value using square bracket syntax and print it
            inventory["Health Potion"] = 20;
            Console.WriteLine("Health Potion quantity: " + inventory["Health Potion"]); // 20

            // 4 + Challenge 4 (step 4): accessing a missing key throws KeyNotFoundException,
            // now handled with its own try/catch/finally.
            try
            {
                Console.WriteLine(inventory["Iron Sword"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Item not found in inventory.");
            }
            finally
            {
                Console.WriteLine("Inventory lookup complete.");
            }

            // ==================================================
            // Challenge 5: Custom data types and reference types
            // ==================================================
            Console.WriteLine("\n=== Challenge 5: Reference Types ===");

            // 2. Instantiate student1 and assign properties
            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "Alice Smith";
            student1.Age = 20;

            // 3. Add student1 to a List<Student>
            List<Student> students = new List<Student>();
            students.Add(student1);

            // 4. student2 points at the SAME object as student1
            Student student2 = student1;

            // 5. Change the age via student2
            student2.Age = 99;

            // 6. student1 now shows age 99 because both variables reference one object
            student1.Display();
        }
    }
}