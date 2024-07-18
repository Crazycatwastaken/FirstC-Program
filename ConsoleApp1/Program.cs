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
            public string name;
            public int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"{name} {age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Max", 18);
            // Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());
            
            Console.ReadLine();
        }

        // static string ReturnDetails(Person person)
        // {
        //     return $"{person.name} {person.age}";
        // }

   
    }

}