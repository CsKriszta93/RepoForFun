using System;
using System.IO;
using Xunit;

namespace Nexogen.HR.Logger.UnitTests
{
    public class ConsoleLoggerTests
    {
        [Fact]
        public void ConsoleLoggerTest_TestWriteSuccessful()
        {
            string result;
            using (var ms = new MemoryStream())
            {
                using (TextWriter tw = new StreamWriter(ms))
                {
                    Console.SetOut(tw);

                    ConsoleLogger logger = new ConsoleLogger();

                    logger.Log(LogLevel.Info, "Test message");
                    tw.Flush();
                    ms.Flush();
                    ms.Position = 0;
                    using (var sr = new StreamReader(ms))
                    {
                        result = sr.ReadToEnd();
                    }

                    Assert.Contains("Test message", result);
                }
            }
        }
    }
}
