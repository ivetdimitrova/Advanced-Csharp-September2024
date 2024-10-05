using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OldestFamilyMember
{
    public class StartUp
    {
        static void Main()
        {
            Family family = new Family();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Person person = new Person(data[0], int.Parse(data[1]));

                family.AddMembers(person);
            }

            Console.WriteLine(family.GetOldestMember());
        }

    }
}
