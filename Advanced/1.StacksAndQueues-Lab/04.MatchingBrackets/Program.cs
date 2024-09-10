namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                string subexpression = string.Empty;
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    subexpression = expression.Substring(startIndex, i - startIndex+1);

                    Console.WriteLine(subexpression);
                }
            }
        }
    }
}
