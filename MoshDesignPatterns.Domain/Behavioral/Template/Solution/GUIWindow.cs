using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Behavioral.Template
{
    public class GUIWindow : Window
    {
        protected override void OnClosing()
        {
            Console.WriteLine($"Doing stuff before {nameof(GUIWindow)} closes.");
        }

        protected override void OnClosed()
        {
            Console.WriteLine($"Doing stuff after {nameof(GUIWindow)} closes.");
        }
    }
}
