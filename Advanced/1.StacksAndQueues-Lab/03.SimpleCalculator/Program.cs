using System.Linq.Expressions;

namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ').ToArray();


            Stack<string> stack = new Stack<string>();
            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                stack.Push(tokens[i]);
            }


            int result = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                string operation = stack.Pop();

                int nextNumber = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    result += nextNumber;
                }
                else if (operation == "-")
                {
                    result -= nextNumber;
                }
            }

            Console.WriteLine(result);
        }
    }
}

