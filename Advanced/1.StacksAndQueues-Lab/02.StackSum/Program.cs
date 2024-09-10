namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(numbers1);

            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] arguments = input.Split();

                string command = arguments[0];
                switch (command)
                {
                    case "add":
                        if(arguments.Length == 3)
                        {
                            int num1 = int.Parse(arguments[1]);
                            int num2 = int.Parse(arguments[2]);

                            numbers.Push(num1);
                            numbers.Push(num2);
                        }
                        break;
                    case "remove":
                        if (arguments.Length == 2)
                        {
                            int range = int.Parse(arguments[1]);
                            if (range <= numbers.Count)
                            {
                                for (int i = 0; i < range; i++)
                                {
                                    numbers.Pop();
                                }
                            }
                        }
                        break;
                }
            }

            int sum = 0;
            while (numbers.Count > 0)
            {
                sum += numbers.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
