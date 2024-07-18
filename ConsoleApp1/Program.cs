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

            var shoppingList = new List<string>
            {
                "Coffee", "Milk"
            };

            Console.WriteLine(shoppingList.IndexOf("Coffee"));
            Console.WriteLine(findInList("Coffee", shoppingList, out int index));
            Console.WriteLine(index);

            
            
            Console.ReadLine();
        }

        static bool findInList(string search, List<string> list, out int index) // Passing in a string varable with whatever name, declaring a list variable nad writing out an int index.
        {
            index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(search.ToLower()))
                {
                    index = i;
                }
            }
            return index > -1;
        }
        
        static void test(out int num)
        {
            num = 5;
        }

        


    }
}