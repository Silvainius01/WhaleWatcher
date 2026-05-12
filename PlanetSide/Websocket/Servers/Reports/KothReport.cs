using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhaleWatcher;

namespace WhaleWatcher.Websocket
{
    public struct KothReport
    {
        public PlanetStats VS_Stats { get; set; }
        public PlanetStats NC_Stats { get; set; }
        public PlanetStats TR_Stats { get; set; }
    }
}
