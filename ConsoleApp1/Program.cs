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
            Console.Write("What is the base of the triangle: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the height of the triangle: ");
            int Height = Convert.ToInt32(Console.ReadLine());
            
            int result = AreaOfTriangle(Base, Height);
            Console.WriteLine($"The area of the triangle {result}");
          
            Console.ReadLine();
          
        }

        static int AreaOfTriangle(int Base, int Height)
        {
            
            return (Base * Height) / 2;
        }

        
    }

}