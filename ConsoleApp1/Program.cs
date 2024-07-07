// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = -10D / 3D;
            Console.WriteLine(string.Format("-$10 / $3 = ${0:0.00}", money));
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-JP")));
            Console.ReadLine();
            
        }
        
    }
}