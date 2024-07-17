// See https://aka.ms/new-console-template for more information


using System.Text;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            CreateAndPrintArrary();
            Console.ReadLine();
            
        }

        static void CreateAndPrintArrary()
        {
            int[] numbers = new int[]
            {
                0, 1, 3
            };

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item} ");
            }
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Wecome Message");
        }

    }
}