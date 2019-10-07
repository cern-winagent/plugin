using Newtonsoft.Json.Linq;
using System;

namespace plugin
{
    public interface IOutputPlugin
    {
        event EventHandler<MessageEventArgs> MessageEvent;

        void Execute(string jsonData, JObject settings);
    }
}