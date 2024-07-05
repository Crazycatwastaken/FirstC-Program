// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            Console.WriteLine(age);

            long largeNumber = 90000000L;
            Console.WriteLine(largeNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.000001F;

            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;

            Console.WriteLine(money);
            Console.WriteLine(Decimal.MaxValue);
            Console.WriteLine(Decimal.MinValue);
            
            
            Console.ReadLine();
            
        }
        
    }
}