using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OpinionPoll
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

    }
}
