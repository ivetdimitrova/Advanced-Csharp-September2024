using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OldestFamilyMember
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public List<Person> Members
        {
            get { return members;}
            set { members = value; }
        }

        public void AddMembers(Person person)
        {
            this.Members.Add(person);
        }

        public string  GetOldestMember()
        {
               this.Members = this.Members.OrderByDescending(person => person.Age).Take(1).ToList();

              return $"{Members[0].Name} {this.Members[0].Age}";
        }
    }
}
