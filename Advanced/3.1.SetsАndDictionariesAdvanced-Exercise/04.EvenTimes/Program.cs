namespace _04.EvenTimes
{
        internal class Program
        {
            static void Main(string[] args)
            {
                   int count = int.Parse(Console.ReadLine());

                  Dictionary<int, int> countByNumber = new Dictionary<int, int>();

                  for (int i = 0; i < count; i++)
                  {
                       int number = int.Parse(Console.ReadLine());

                     if (!countByNumber.ContainsKey(number))
                     {
                             countByNumber.Add(number, 0);
                     }

                          countByNumber[number]++;
                  }

                  foreach (var (number,times) in countByNumber)
                  {
                      if (times % 2 == 0)
                      {
                          Console.WriteLine(number);
                      }
                  }
            }
        }
}


    

