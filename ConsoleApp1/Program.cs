// See https://aka.ms/new-console-template for more information


using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{


    class Program
    {
        // struct Person
        // {
        //     public string name;
        //     public int age;
        //
        //
        //     public Person(string name, int age)
        //     {
        //         this.name = name;
        //         this.age = age;
        //     }
        // }

        class Person
        {
            public string name;
            public int age;

            public Person()
            {

            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }
            public Person(int age)
            {
                this.name = "";
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Max", 18);
            Console.Write($"{person.name} {person.age}");
            
            Console.ReadLine();
        }

   
  
        

 
        
    }

}