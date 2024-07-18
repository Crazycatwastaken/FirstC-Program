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
            Console.Write("Enter a number: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Something has went wrong");
               
            }

            Console.ReadLine();
          
        }
        

 
        
    }

}