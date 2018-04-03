using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Nexogen.HR.Logger;

namespace Log.Rotater
{
    public class Program
    {
         static void Main(string[] args)
         {
            int index = 0;
            string fileName = "nexogen." + index + ".log";

            FileStream stream = new FileStream(fileName, FileMode.CreateNew);
            {
                using (StreamWriter archive = new StreamWriter(stream))
                {
                    archive.WriteLine("BAAAANnng!!!");
                    archive.Close();
                }
            }
          
            long length = new FileInfo(fileName).Length;
            Console.WriteLine(length);
            Console.ReadKey();

            StreamLogger streamLogger = new StreamLogger(stream);
            
            streamLogger.Log(LogLevel.Info, "logging");
        }
    }
}
