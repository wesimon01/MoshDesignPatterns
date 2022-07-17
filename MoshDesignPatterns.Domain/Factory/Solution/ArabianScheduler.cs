using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Factory
{
    public class ArabianScheduler : Scheduler
    {
        public ArabianScheduler() : base()
        {
        }

        protected override ICalendar CreateCalendar()
        {
            return new ArabianCalendar();
        }
    }
}
