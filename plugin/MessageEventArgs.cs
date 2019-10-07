using System;
using System.Diagnostics;

namespace plugin
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
        public EventLogEntryType Type { get; set; }
        public Exception Exception { get; set; } = null;
    }
}
