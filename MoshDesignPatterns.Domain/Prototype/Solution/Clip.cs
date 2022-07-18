using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Prototype
{
    public class Clip : IComponent
    {
        public byte[] data { get; private set; }

        public Clip(byte[] data)
        {
            this.data = data;
        }

        public IComponent Clone()
        {
            Clip newClip = new(data);
            return newClip;
        }
    }
}
