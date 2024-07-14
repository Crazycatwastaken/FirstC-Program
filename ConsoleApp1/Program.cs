// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\maxra\\Pictures\\Camera";
            Console.WriteLine(path);
            // Same as \\ but without escape char with @
            path = @"C:\Users\maxra\Pictures\Camera";
            Console.WriteLine(path);

            string name = "Hello \"something\"";
            Console.WriteLine(name);
            
            name = @"Hello ""something""";
            Console.WriteLine(name);
            Console.ReadLine();
        }
        
    }
}