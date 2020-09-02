using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    public class Log : ILogBehavior
    {
        public List<ILogEntry> Entries { get; set; }
        public Log()
        {
            Entries = new List<ILogEntry>();
        }

        public void Save()
        {                        
            using (StreamWriter sw = new StreamWriter("log.txt"))
            {
                ILogEntry lastEntry = Entries[Entries.Count - 1];
                sw.Write(lastEntry.Level + " : " + lastEntry.TimeStamp + " - " + lastEntry.Message + System.Environment.NewLine);
            }
        }

        public string Read()
        {
            string readAll = string.Empty;
            using (StreamReader sr = new StreamReader("log.txt"))
            {
                readAll = sr.ReadToEnd();
            }

            return readAll;
        }
    }
}
