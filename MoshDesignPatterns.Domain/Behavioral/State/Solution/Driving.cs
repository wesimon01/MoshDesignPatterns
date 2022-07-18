﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.State
{
    public class Driving : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }
    }
}
