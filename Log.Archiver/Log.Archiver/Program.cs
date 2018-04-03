using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Log.Rotater
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = 0;
            string fileName = "nexogen." + index + ".log";

            //StreamWriter archive = new StreamWriter(fileName, true, Encoding.Default);
            //archive.WriteLine("BAAAANnng!!!");

            //archive.Close();

            //long length = new FileInfo(fileName).Length;
            //Console.WriteLine(length);
            //Console.ReadKey();

            StreamLogger(fileName);
            Log(LogLevel.Info, "logging");
        }
    }
}
