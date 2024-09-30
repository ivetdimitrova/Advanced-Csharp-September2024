namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

           int capacity = int.Parse(Console.ReadLine());

           int racks = 1;
           int sum = 0;
           while (clothes.Count > 0)
           {
               int count = clothes.Pop();
               sum += count;
               if(sum > capacity)
               {
                   racks++;
                   sum = count;
               }
           }

           Console.WriteLine(racks);
        }
    }
}
