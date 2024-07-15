// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sets empty password
            string password = null;

            // Runs this while password is empty.
            while (string.IsNullOrEmpty(password))
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                // Checks if this password is empty and promts the user to enter a password.
                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Please enter a password ");
                }
            }
        
            // Checks if this password is not empty
            if (!string.IsNullOrEmpty(password))
            {
                // Asks to re-enter password
                Console.Write("Please re-enter your password: ");
            
                // Checks if password is equal to the readline. (The password the user entered again)
                if (password.Equals(Console.ReadLine()))
                {
                    Console.WriteLine("Your passwords match");
                }
                else
                {
                    Console.WriteLine("Your passwords do not match");
                }
                Console.ReadLine();
            }


        }
        
    }
}