// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("What is your message: ");
            string message = Console.ReadLine();



            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();
            
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }

            

            Console.ReadLine();
        }
        
    }
}