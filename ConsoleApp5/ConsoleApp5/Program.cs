using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface ILogger
    {
        void WriteLog(string log);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("SomeLog");
        }
    }
}
