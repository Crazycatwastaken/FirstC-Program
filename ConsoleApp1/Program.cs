// See https://aka.ms/new-console-template for more information


using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5
            };
            // int Result = SumOfNumbers(numbers, out int total);
            //
            // Console.WriteLine(Result > 0 ? total : "No numbers in array");

            Console.WriteLine(SumOfNumbers(numbers, out int total) == true ? total : "No numbers in arrary");
            Console.ReadLine();
          
        }

        // static int SumOfNumbers(int[] numbers)
        // {
        //     if (numbers.Length < 1)
        //     {
        //         return -1;
        //     }
        //
        //     return numbers.Sum();
        // }
        
        static bool SumOfNumbers(int[] numbers, out int total)
        {
            if (numbers.Length < 1)
            {
                total = 0;
                return false;
            }

            total = numbers.Sum();
            return true;
        }

        
    }

}