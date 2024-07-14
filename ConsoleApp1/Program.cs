// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Max";
            int age = 18;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();
            Console.WriteLine("Name: " + name + "\nAge: " + age);
            Console.WriteLine("Your name is " + name + " and your age is " + age);
            // , adds an object to replace {0/1}
            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
            Console.WriteLine("Name: {0}\nAge: {1}", name, age);
            
            Console.ReadLine();
        }
        
    }
}