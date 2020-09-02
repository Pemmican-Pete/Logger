using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LogEntry : ILogEntry
    {
        string ILogEntry.Message { get; set; }
        LogLevel ILogEntry.Level { get; set; }
        DateTime ILogEntry.TimeStamp { get; set; }
    }
}
