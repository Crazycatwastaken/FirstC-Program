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
            private string name;
            private int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string Name
            {
                get => name;
                set => name = value;
            }

            public int Age
            {
                get => age;
                set => age = value;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Max", 18);
            person.Name = "Harry";
            Console.WriteLine($"{person.Name} - {person.Age}");
            
            Console.ReadLine();
        }

        // static string ReturnDetails(Person person)
        // {
        //     return $"{person.name} {person.age}";
        // }

   
    }

}