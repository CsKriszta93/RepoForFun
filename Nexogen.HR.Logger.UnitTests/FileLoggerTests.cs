using System;
using System.IO;
using Xunit;

namespace Nexogen.HR.Logger.UnitTests
{
    public class FileLoggerTests
    {
        [Fact]
        public void FileLoggerTest_TestWriteSuccessful()
        {
            try
            {
                string result;
                using (FileLogger logger = new FileLogger("test.txt"))
                {
                    logger.Log(LogLevel.Info, "Test message");
                }

                using (var fs = File.Open("test.txt", FileMode.Open))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        result = sr.ReadToEnd();
                    }
                }
                Assert.Contains("Test message", result);
            }
            finally
            {
                File.Delete("test.txt");
            }
        }
    }
}
