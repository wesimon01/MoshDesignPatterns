using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Factory
{
    public class GregorianCalendar : ICalendar
    {
        public void AddEvent(Event e, DateTime date)
        {
            Console.WriteLine("Adding an event on the given date. (gregorian calendar)");
        }
    }
}
