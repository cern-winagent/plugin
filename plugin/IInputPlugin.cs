using Newtonsoft.Json.Linq;
using System;

namespace plugin
{
    public interface IInputPlugin
    {
        event EventHandler<MessageEventArgs> MessageEvent;

        string Execute(JObject settings);
    }
}