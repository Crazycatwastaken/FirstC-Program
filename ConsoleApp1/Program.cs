// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What number would you like for the times table: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < 10)
            {
                i++;
                int multiplication = number * i;
                Console.WriteLine(number + " times " + i + " = " + multiplication);
            }
            Console.ReadLine();
        }
        
    }
}