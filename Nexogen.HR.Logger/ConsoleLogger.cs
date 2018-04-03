using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexogen.HR.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(LogLevel level, string message)
        {
            Console.WriteLine(string.Format("{0} - [{1}] {2}", DateTime.Now, level.ToString(), message));
        }
    }
}
