namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Queue<string> vehicles = new Queue<string>();
            int count1 = 0;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    if (count > vehicles.Count)
                    {
                        count = vehicles.Count;
                    }
                    for (int i = 0; i < count; i++)
                    {
                            Console.WriteLine($"{vehicles.Dequeue()} passed!");
                            count1++;
                    }
                    continue;
                }

                vehicles.Enqueue(input);
            }

            Console.WriteLine($"{count1} cars passed the crossroads.");

        }
    }
}
