using System;

class Program
{
    static void Main()
    {
        string[] parts = { "hydraulic pump", "PLC module", "servo motor" };

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");

        while (true)
        {
            Console.Write("Which part do you need? ");
            string input = Console.ReadLine() ?? "";

            bool found = false;
            foreach (var p in parts)
            {
                if (input == p)
                {
                    Console.WriteLine($"I've got {p} here for you");
                    return; // programmet slutter når en del er fundet
                }
            }

            string low = input.ToLower();
            if (low.Contains("any parts") || low.Contains("anything in stock"))
            {
                Console.WriteLine($"We have {parts.Length} part(s)!");
                foreach (var p in parts) Console.WriteLine(p);
                continue;
            }

            Console.WriteLine($"I am afraid we don't have any {input} in the inventory");
        }
    }
}