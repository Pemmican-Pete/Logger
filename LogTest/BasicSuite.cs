using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger;

namespace LogTest
{
    [TestClass]
    public class BasicSuite
    {
        [TestMethod]
        public void BasicTest1()
        {
            // Create and add a log entry
            Log log = new Log();
            ILogEntry entry = new LogEntry();
            entry.Message = "Test Message";
            entry.Level = LogLevel.Debug;
            entry.TimeStamp = DateTime.Now;
            log.Entries.Add(entry);

            // Save the log entry
            log.Save();

            // Read and verify the log entry is correct
            string readText = log.Read();
            string readLevel = readText.Split(':')[0];
            string readMessage = readText.Split('-')[1];
            Assert.IsTrue(readLevel.Trim() == "Debug");
            Assert.IsTrue(readMessage.Trim() == "Test Message");
        }
    }
}
