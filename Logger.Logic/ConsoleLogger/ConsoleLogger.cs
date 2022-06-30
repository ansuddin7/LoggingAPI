using Logger.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logic.ConsoleLogger
{
    public class ConsoleLogger : IConsoleLogger
    {

        public void AddEntry(LogEntry logEntry)
        {
            Console.WriteLine(Helper.Helper.ConvertToString(logEntry));
        }

        public void AddEntries(List<LogEntry> logEntries)
        {
            foreach(LogEntry logEntry in logEntries)
            {
                Console.WriteLine(Helper.Helper.ConvertToString(logEntry));
            }
        }
    }
}
