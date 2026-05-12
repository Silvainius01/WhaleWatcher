using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhaleWatcher.Websocket
{
    public struct ServerReport
    {
        public string Topic { get; set; }
        public string Data { get; set; }

        public bool DontPublish { get; set; }
        public bool DebugData { get; set; }
    }
}
