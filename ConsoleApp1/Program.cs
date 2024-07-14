// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");  
            string name = Console.ReadLine();

            if (name != string.Empty) // Better then "" as " " is wrong.
            { 
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Error your name is empty");
            }
            
            
            Console.ReadLine();
        }
        
    }
}