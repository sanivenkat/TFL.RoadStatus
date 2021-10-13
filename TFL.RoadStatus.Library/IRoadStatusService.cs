using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TFL.RoadStatus.Library
{
   public interface IRoadStatusService
    {
        Response GetRoadStatus(string roadId, string TFLAPIUrl, string APIKey);
    }
}
