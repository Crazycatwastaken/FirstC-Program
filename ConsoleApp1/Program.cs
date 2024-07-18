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
                
            };
            int Result = SumOfNumbers(ref numbers);

            Console.WriteLine(Result > 0 ? Result : "No numbers in array");
            Console.ReadLine();
          
        }

        static int SumOfNumbers(ref int[] numbers)
        {
            if (numbers.Length < 1)
            {
                return -1;
            }

            return numbers.Sum();
        }

        
    }

}