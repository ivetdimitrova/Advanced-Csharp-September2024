﻿namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }

                    names.Clear();

                    continue;
                }

                names.Enqueue(input);
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
