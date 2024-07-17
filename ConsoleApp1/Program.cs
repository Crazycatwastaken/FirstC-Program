// See https://aka.ms/new-console-template for more information


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var names = new Dictionary<int, string>()
            // {
            //     { 1, "Max" },
            //     { 2, "Test" }
            // };
            //
            //
            // names.Add(3, "Testing");
            //
            // for (int i = 0; i < names.Count; i++)
            // {
            //     
            //     var pair = names.ElementAt(i);
            //     Console.WriteLine($"{pair.Key} - {pair.Value}");
            // }
            //
            // foreach (var name in names)
            // {
            //     Console.Write(name);
            //     Console.WriteLine($"{name.Key} - {name.Value}");
            // }

            var teachers = new Dictionary<string, string>()
            {
                { "Math", "Max" },
                { "Science", "box" }
            };

            //Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Math", out var teacher)) // places the output variable into teacher Can be out string teacher
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Teacher not found");
            }



            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("math not found");
            }
            
            foreach (var name in teachers)
            {
                Console.WriteLine($"{name.Key} - {name.Value}");
            }

            Console.ReadLine();
            


        }
        
    }
}