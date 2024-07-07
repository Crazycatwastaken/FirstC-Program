// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            int num = 0;

            bool success = int.TryParse(numInput, out num);
            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Unable to convert number.");
            }
            
            
            Console.ReadLine();
        }
        
    }
}