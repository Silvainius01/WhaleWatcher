using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhaleWatcher;

namespace WhaleWatcher.Websocket
{
    public struct HammaReport
    {
        public PlanetStats TeamOneStats { get; set; }
        public PlanetStats TeamTwoStats { get; set; }
    }
}
