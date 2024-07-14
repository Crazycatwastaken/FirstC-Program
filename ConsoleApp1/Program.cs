// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare)) // Better then == 
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Your name: ");
            string name = Console.ReadLine();
            
            //if (name != "")
            if (!name.Equals(""))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Error");
            }
            
            Console.ReadLine();
        }
        
    }
}