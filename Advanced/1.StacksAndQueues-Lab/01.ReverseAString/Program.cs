﻿namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversed = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reversed.Push(input[i]);
            }

            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }
        }
    }
}
