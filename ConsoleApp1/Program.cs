// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[]
            {
                9, 129, 42
            };
            
            Array.Sort(numbers);
            
            foreach (var num in numbers)
            {
                Console.WriteLine($"Your numbers are {num} ");
            }
            
            Console.ReadLine();
            


        }
        
    }
}