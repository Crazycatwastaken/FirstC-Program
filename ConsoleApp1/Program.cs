// See https://aka.ms/new-console-template for more information


namespace ConsoleApp1
{

    class Test
    { 
        // Function outside program
        public static void Something()
        {
            Console.WriteLine("Something");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            Test.Something();
            Console.ReadLine();
            
        }

       // Function within program
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome Max");
        }
    }
}