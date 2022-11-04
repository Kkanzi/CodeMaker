using System;
using System.Diagnostics;

namespace KJHCore
{
    public class PsnLog
    {
        private EventLog psnEventLog;
        private string sourceName;
        private string logName;

        public string SourceName => this.sourceName;

        public string LogName => this.logName;

        public EventLog PsnEventLog
        {
            get => this.psnEventLog;
            set => this.psnEventLog = value;
        }

        public PsnLog()
        {
            try
            {
                this.PsnEventLog = new EventLog();
                this.PsnEventLog.BeginInit();
                this.sourceName = "CodeMaker_LogSource";
                this.logName = "CodeMaker_Log";
                if (!EventLog.SourceExists(this.SourceName))
                    EventLog.CreateEventSource(this.SourceName, this.LogName);
                this.PsnEventLog.Source = this.SourceName;
                this.PsnEventLog.Log = this.LogName;
            }
            catch (Exception ex)
            {
            }
        }

        public void WriteEventLog(string message) => this.PsnEventLog.WriteEntry(message);
    }
}
