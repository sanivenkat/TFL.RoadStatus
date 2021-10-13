using System;
using System.Collections.Generic;
using System.Text;

namespace TFL.RoadStatus.Library
{
    public class RoadStatus
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string StatusSeverity { get; set; }
        public string StatusSeverityDescription { get; set; }
        public string Bounds { get; set; }
        public string Envelope { get; set; }
        public string Url { get; set; }

    }
}
