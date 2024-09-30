namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                //The count of items we need to enter, the count of items we need to remove and the number we are looking for
                int n = command[0], s = command[1], x = command[2];

                //Entering the numbers
                Queue<int> numbers = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

                //Removing the numbers
                if (s <= n)
                {
                    for (int i = 0; i < s; i++)
                        numbers.Dequeue();
                }

                //Checking if there are elements on the stack
                if (numbers.Count > 0)
                {
                    //Checking if this number exists
                    if (numbers.Contains(x))
                        Console.WriteLine("true");
                    else
                        Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }


            
        }
    }

}
