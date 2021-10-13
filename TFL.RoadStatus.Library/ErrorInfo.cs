using System;
using System.Collections.Generic;
using System.Text;

namespace TFL.RoadStatus.Library
{
   public class ErrorInfo
    {
        public string TimestampUtc { get; set; }
        public string ExceptionType { get; set; }
        public string HttpStatusCode { get; set; }
        public string HttpStatus { get; set; }
        public string RelativeUri { get; set; }
        public string Message { get; set; }

    
    }
}
