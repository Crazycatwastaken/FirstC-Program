// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first Number: ");
            int NumberA = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the Second Number: ");
            int NumberB = Convert.ToInt32(Console.ReadLine());

            int answer = NumberA * NumberB;
            int actualAnswer = 0;
            Console.WriteLine("Whats the value of " + NumberA + " x " + NumberB + "?");
            Console.WriteLine();
    
            while (answer != actualAnswer)
            {
                Console.Write("Enter your Answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("You're incorrect");
                }
            }

            Console.WriteLine("You're Correct!");
            

            
            Console.ReadLine();
            
        }
        
    }
}