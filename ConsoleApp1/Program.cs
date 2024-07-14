// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Max";
            int age = 18;

           
            Console.WriteLine("Your name is " + name + " and your age is " + age);
            Console.WriteLine($"Your name is {name} and your {age} is age");
          
            Console.ReadLine();
        }
        
    }
}