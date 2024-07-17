// See https://aka.ms/new-console-template for more information


using System.Text;

namespace ConsoleApp1
{


    class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 5));
            int num = Readint("Number");
            Console.WriteLine(num);

            int angle = Readint("Angle");
            Console.WriteLine(angle);

            int firstNum = Readint("Enter first number: ");
            int secondNum = Readint("Enter Second number: ");
            int result = Add(firstNum, secondNum);
            Console.WriteLine(result);

            
            
            Console.ReadLine();
            
        }

        static int Readint(string message)
        {
            Console.Write($"{message}");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        


    }
}