using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.State
{
    public interface ITravelMode
    {
        object GetEta();
        object GetDirection();
    }
}
