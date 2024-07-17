// See https://aka.ms/new-console-template for more information


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var even = new List<int>();
            var odd = new List<int>();
            int numbers;

            Console.WriteLine("How many numbers: ");
            numbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Even Numbers:");

            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("Odd Numbers:");
            
            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }
            
            Console.ReadLine();
            


        }
        
    }
}