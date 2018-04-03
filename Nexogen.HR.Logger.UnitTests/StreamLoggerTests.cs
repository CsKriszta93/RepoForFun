using System;
using System.IO;
using Xunit;

namespace Nexogen.HR.Logger.UnitTests
{
     public class StreamLoggerTests
    {
        [Fact]
        public void StreamLoggerTest_TestWriteSuccessful()
        {
            string result;
            using (var ms = new MemoryStream())
            {
                using (StreamLogger logger = new StreamLogger(ms))
                {
                    logger.Log(LogLevel.Info, "Test message");

                    ms.Flush();
                    ms.Position = 0;
                    using (var sr = new StreamReader(ms))
                    {
                        result = sr.ReadToEnd();
                    }
                }
            }
            Assert.Contains("Test message", result);
        }
    }
}
