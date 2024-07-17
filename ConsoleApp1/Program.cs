// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{


    class Program
    
    {
        static void Main(string[] args)
        {

            int result = Add(5);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }
        
        static int Add(int a,[Optional] int b) // Or int b = default / 0
        {
            return a + b;
        }
        


    }
}