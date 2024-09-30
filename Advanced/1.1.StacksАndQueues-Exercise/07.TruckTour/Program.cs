namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> stations = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] currentStation = Console.ReadLine().Split().Select(int.Parse).ToArray();

                stations.Enqueue(currentStation);
            }

            for (int i = 0; i < n; i++)
            {
                if (CanFinishRoute(stations))
                {
                    Console.WriteLine(i);
                    break;
                }

                stations.Enqueue(stations.Dequeue());
            }
        }

        private static bool CanFinishRoute(Queue<int[]> stations)
        {
            int fuel = 0;
            bool canFinish = true;

            for (int i = 0; i < stations.Count; i++)
            {
                int[] currentStation = stations.Dequeue();

                fuel += currentStation[0] - currentStation[1];

                if (fuel < 0) canFinish = false;

                stations.Enqueue(currentStation);

            }

            return canFinish;
        }
    }
}
