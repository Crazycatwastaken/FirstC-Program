// See https://aka.ms/new-console-template for more information


using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{


    class Program
    
    {
        static void Main(string[] args)
        {
            int num = 0;
            test(out num);
            Console.WriteLine(num);
            
            
            Console.ReadLine();
        }

        static void test(out int num)
        {
            num = 5;
        }

        


    }
}