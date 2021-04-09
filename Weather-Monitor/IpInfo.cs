using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_Monitor
{
    class IpInfo
    { 
        public class root
        {
            public string ip { get; set; }

            public string city { get; set; }

        }
    }
}
