// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[]
            {
                0, 1, 2, 3, 4, 5
            };
            Console.Write("What is your search? ");
            int search = Convert.ToInt32(Console.ReadLine());
            int positon = Array.IndexOf(numbers, search);
            // int positon = Array.IndexOf(numbers, search, 2); Start index of 2
            // int positon = Array.IndexOf(numbers, search, 1, 2); Search index from postions 1 and 2

            if (positon > -1)
            {
                Console.WriteLine($"Number {search} was found at postion {positon + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not be found");
            }
            
            
            Console.ReadLine();
            


        }
        
    }
}