// See https://aka.ms/new-console-template for more information


using System.Text;

namespace ConsoleApp1
{


    class Program
    
    {
        static void Main(string[] args)
        {
            Console.Title = returnName();
            PrintIntro();
            Console.ReadLine();
            
        }

        // Returns variable from a function
        static string returnName()
        {
            return "Bob";
        }

        static void PrintIntro()
        {
            Console.WriteLine(returnName());
        }


    }
}