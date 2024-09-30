using System.Runtime.InteropServices;

namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] count = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < count[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < count[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            if (set1.Count > set2.Count)
            {
                PrintUniqueElements(set1, set2);
            }
            else
            {
                PrintUniqueElements(set2,set1);
            }
        }

        private static void PrintUniqueElements(HashSet<int> set1, HashSet<int> set2)
        {
            foreach (int number in set2)
            {
                if (set1.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
