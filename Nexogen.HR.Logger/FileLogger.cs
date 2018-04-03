using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexogen.HR.Logger
{
    public class FileLogger : StreamLogger
    {
        private readonly string filename;

        public FileLogger(string filename) 
            : base(new FileStream(filename, FileMode.Append))
        {
            this.filename = filename;
        }

        public override void Log(LogLevel level, string message)
        {
            base.Log(level, message);
        }
    }
}
