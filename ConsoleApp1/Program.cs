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

            string name = "Bob";
            int age = 23;
            string address = "Bob road 124";
            
            printDetails(name, age, address);
            
            // string nameInput = "Bob";
            // int ageInput = 23;
            // string addressInput = "Bob road 124";
            //
            // printDetails(age:ageInput,
                        //  name: nameInput,
                        //  address: addressInput);
            // Otherway of using it without  being in the same order.
            
            Console.ReadLine();
            
        }

        static void printDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
        


    }
}