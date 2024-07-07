// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number: ");
            int NumberA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the Second Number: ");
            int NumberB = Convert.ToInt32(Console.ReadLine());

            int answer = NumberA * NumberB;
            Console.WriteLine("Value of " + NumberA + " x " + NumberB + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("You're correct");
            }
            else
            {
                Console.WriteLine("You're incorrect");
            }
            
            Console.ReadLine();
            
        }
        
    }
}