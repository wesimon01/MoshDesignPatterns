using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Singleton
{
    public class Logger
    {
        private string? fileName;
        private static Dictionary<string, Logger> loggerInstances = new Dictionary<string, Logger>();   

        private Logger(string fileName)
        {
            this.fileName = fileName;   
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public static Logger GetInstance(string fileName)
        {
            if (!loggerInstances.ContainsKey(fileName)) { 
                loggerInstances.Add(fileName, new Logger(fileName));
            }
            return loggerInstances[fileName];   
        }
    }
}
