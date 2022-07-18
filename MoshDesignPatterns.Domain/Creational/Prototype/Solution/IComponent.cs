using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Prototype
{
    public interface IComponent
    {
        IComponent Clone();
    }
}
