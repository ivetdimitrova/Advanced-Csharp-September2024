using System.Xml.Linq;

namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> chemicalElements = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] elements = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < elements.Length; j++)
                {
                    chemicalElements.Add(elements[j]);
                }
            }

            var sortedChemicalElements = chemicalElements.OrderBy(x => x);
            foreach (string element in  sortedChemicalElements)
            {
               
                    Console.Write(element + " ");
                
            }
        }
    }
}
