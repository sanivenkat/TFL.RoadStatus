using System;
using System.Collections.Generic;
using System.Text;

namespace TFL.RoadStatus.Library
{
   public class Response
    {
        public RoadStatus roadStatus { get; set; }
        public ErrorInfo errorInfo { get; set; }
    }
}
