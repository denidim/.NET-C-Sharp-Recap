using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassPerson
{
    internal class DateModifier
    {
        public static int CalculateDifference(string firstDate, string secondDate)
        {
            DateTime first = DateTime.Parse(firstDate);
            DateTime second = DateTime.Parse(secondDate);

            return (int)Math.Abs((first - second).TotalDays);
        }
    }
}
