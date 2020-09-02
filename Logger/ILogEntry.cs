using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public interface ILogEntry
    {
        string Message { get; set; }
        LogLevel Level { get; set; }
        DateTime TimeStamp { get; set; }
    }
}
