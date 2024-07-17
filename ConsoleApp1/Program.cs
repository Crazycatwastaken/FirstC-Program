// See https://aka.ms/new-console-template for more information


using System.Text;

namespace ConsoleApp1
{


    class Program
    
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[3];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                
                numbers[i] = EnterNumbers();
            }

            foreach (var items in numbers)
            {
                Console.WriteLine($"{items}");
            }
            
            Console.ReadLine();
            
        }

        // Returns variable from a function
        static int EnterNumbers()
        {
            Console.Write("Enter your number ");
            return Convert.ToInt32(Console.ReadLine());
        }


    }
}