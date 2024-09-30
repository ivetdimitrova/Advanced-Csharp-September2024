namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

           
            Stack<int> numbers = new Stack<int>();

           if (n >= 1 && n <= 105)
           {
               for (int i = 0; i < n; i++)
               {
                   int[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                   int numberOfCommand = command[0];
                   if (numberOfCommand >= 1 && numberOfCommand <= 4)
                   {
                       switch (numberOfCommand)
                       {
                           case 1:
                               int number = command[1];
                               if (number >= 1 && number <= 109)
                               {
                                   numbers.Push(number);
                               }
                               break;
                           case 2:
                               numbers.Pop();
                               break;
                           case 3:
                               if(numbers .Count > 0)
                               Console.WriteLine(numbers.Max());
                               break;
                           case 4:
                               if (numbers.Count > 0)
                                    Console.WriteLine(numbers.Min());
                               break;
                       }
                   }

                }
            }
           Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
