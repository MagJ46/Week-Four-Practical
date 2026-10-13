using System;

namespace Week4Practical
{
    internal class Student
    {
        // Private fields
        private int id;
        private string name = string.Empty;
        private int age;

        // Public properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Prints the three details to the console
        public void Display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}