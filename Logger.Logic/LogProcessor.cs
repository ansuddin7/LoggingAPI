using Logger.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logic
{
    public class LogProcessor
    {
        public Action<LogEntry> AddLogEntry;
        public Action<List<LogEntry>> AddLogEntries;

        public void LogMessage(LogEntry logEntry)
        {
            AddLogEntry(logEntry);
        }

        public void LogMessages(List<LogEntry> logEntries)
        {
            AddLogEntries(logEntries);
        }
    }
}
