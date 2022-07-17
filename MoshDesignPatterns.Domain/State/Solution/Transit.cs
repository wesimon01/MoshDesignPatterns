﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.State
{
    public class Transit : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }
    }
}
