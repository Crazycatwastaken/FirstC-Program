// See https://aka.ms/new-console-template for more information


using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{


    class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;

            public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }
        }
        static void Main(string[] args)
        {
            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");
            
            Console.ReadLine();
        }

        static Person ReturnPerson()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            
            Console.Write("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What is your month of birth: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            
            return new Person(name, age, birthMonth);
        }

  
        

 
        
    }

}