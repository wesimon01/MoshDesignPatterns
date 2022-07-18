using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Factory
{
    public class Scheduler
    {
        private ICalendar calendar;

        public Scheduler()
        {
            calendar = CreateCalendar(); 
        }

        public void Schedule(Event e) 
        {       
            var today = new DateTime();
            calendar.AddEvent(e, today);
        }

        protected virtual ICalendar CreateCalendar()
        {
            return new GregorianCalendar();
        }
    }
}
