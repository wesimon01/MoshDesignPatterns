﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.State
{
    public class Bicycling : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }
    }
}
