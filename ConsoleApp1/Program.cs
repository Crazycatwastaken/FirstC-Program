// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";

            Console.WriteLine(message[0]); // Returns C

            // int i = 0;
            // while (i < message.Length)
            // {
            //     Console.Write(message[i]);
            //     i++;
            // }

            Console.WriteLine();
            for (int j = 0; j < message.Length; j++)
            {
                Console.Write(message[j]);
                Thread.Sleep(50);
            }

            Console.WriteLine();
            foreach (char character in message)
            {
                Console.Write(character);
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains('C'));

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('a'))
                {
                    contains = true;
                }
            }

            Console.WriteLine(contains);


            Console.ReadLine();
        }
        
    }
}