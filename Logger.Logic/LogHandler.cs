using Logger.Data.DTO;
using Logger.Logic.ConsoleLogger;
using Logger.Logic.FileLogger;

namespace Logger.Logic
{
    public class LogHandler : ILogHandler
    {
        private readonly LogProcessor _processor;

        public LogHandler(LogProcessor processor, IFileLogger fileLogger, IConsoleLogger consoleLogger)
        {
            // The log methods are registered here.
            _processor = processor;
            
            _processor.AddLogEntry += fileLogger.AddEntry;
            _processor.AddLogEntries += fileLogger.AddEntries;
            
            _processor.AddLogEntry += consoleLogger.AddEntry;
            _processor.AddLogEntries += fileLogger.AddEntries;
        }

        public void AddEntry(LogEntry logEntry)
        {
            _processor.LogMessage(logEntry);
        }

        public void AddEntries(List<LogEntry> logEntries)
        {
            _processor.LogMessages(logEntries);
        }
    }
}
