using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexogen.HR.Logger
{
    public class StreamLogger : ILogger, IDisposable
    {
        protected StreamWriter streamWriter;

        public StreamLogger(Stream stream)
        {
            streamWriter = new StreamWriter(stream);
        }

        public void Dispose()
        {
            streamWriter.Flush();
            streamWriter.Dispose();
        }

        public virtual void Log(LogLevel level, string message)
        {
            streamWriter.WriteLine(string.Format("{0} - [{1}] {2}", DateTime.Now, level.ToString(), message));

            streamWriter.Flush();
        }
    }
}
