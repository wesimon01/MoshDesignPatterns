﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Factory
{
    public interface ICalendar
    {
        void AddEvent(Event e, DateTime date);
    }
}
