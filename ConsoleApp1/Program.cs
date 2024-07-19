// See https://aka.ms/new-console-template for more information


using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // public string Name
            // {
            //     get => name;
            //     set => name = value;
            // }
            //
            // public int Age
            // {
            //     get => age;
            //     set => age = value;
            // }

            public override string ToString()
            {
                return $"Name: {Name}";
            }
            
        }
        static void Main(string[] args)
        {
            Person person = new Person("Max", 18);
            var test = new Person("Max", 18)
            person.Name = "Harry";

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            
            
            Console.ReadLine();
        }
        
   
    }

}