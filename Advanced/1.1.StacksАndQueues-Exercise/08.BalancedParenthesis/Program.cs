using System.Runtime.Serialization.Formatters;

namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            if (IsBalanced(input))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static bool IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in expression)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();
                    if (!IsMatchingPair(top, ch))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private static bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
    }
}