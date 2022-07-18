﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Prototype
{
    public class Audio : IComponent
    {
        public byte[] data { get; private set; }

        public Audio(byte[] data)
        {
            this.data = data;
        }

        public IComponent Clone()
        {
            Audio newAudio = new(data);
            return newAudio;
        }
    }
}
