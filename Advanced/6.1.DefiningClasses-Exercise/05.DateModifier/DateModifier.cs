using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateModifier
{
     public class DateModifier
    {
        public int CalculateDifferenceInDays(string first, string second)
        {
            DateTime firstDate = DateTime.Parse(first);
            DateTime secondDate = DateTime.Parse(second);

            TimeSpan difference = firstDate - secondDate;

            return Math.Abs(difference.Days);
        }

    }
}
