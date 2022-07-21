using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Behavioral.Template
{
    public abstract class Window
    {
        public void Close()
        {
            OnClosing();
            Console.WriteLine("Removing the window from the screen");
            OnClosed();
        }

        protected virtual void OnClosed() { }
        protected virtual void OnClosing() { }
    }
}
