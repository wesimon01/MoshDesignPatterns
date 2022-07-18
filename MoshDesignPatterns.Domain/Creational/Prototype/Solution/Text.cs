using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Prototype
{
    public class Text : IComponent
    {
        public string content { get; private set; }

        public Text(string content)
        {
            this.content = content;
        }

        public IComponent Clone()
        {
            Text newText = new(content);
            return newText;
        }
    }
}
