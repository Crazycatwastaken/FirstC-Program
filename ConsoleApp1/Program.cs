// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your name: ");
            string name = Console.ReadLine();
            
            
            Console.Write("Enter Your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            
            Console.WriteLine("Your Name is " + name + " and you're " + age + " years old ");

            if (age >= 18)
            {
                Console.WriteLine("You're 18 or older");
            }
            else
            {
                Console.WriteLine("You're under 18");
            }
            
            Console.ReadLine();
            
        }
        
    }
}