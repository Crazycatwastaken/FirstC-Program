// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[]
            {
                1, 2, 3
            };

            List<int> ListNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                ListNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < ListNumbers.Count; i++)
            {
                Console.WriteLine(ListNumbers[i]);
            }
            
            ListNumbers.RemoveAt(0);

            foreach (var numb in ListNumbers)
            {
                Console.WriteLine($"{numb}");
            }

            Console.ReadLine();
            


        }
        
    }
}