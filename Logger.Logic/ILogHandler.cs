using Logger.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logic
{
    public interface ILogHandler
    {
        void AddEntry(LogEntry logEntry);

        void AddEntries(List<LogEntry> logEntries);
    }
}
