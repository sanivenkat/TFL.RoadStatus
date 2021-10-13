using System;
using System.Net.Http;
using TFL.RoadStatus.Library;
using System.Configuration;

namespace TFL.RoadStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            string TFLAPIUrl = ConfigurationManager.AppSettings["TFLAPIUrl"];
            string APIKey = ConfigurationManager.AppSettings["APIKey"];

            IRoadStatusService roadStatusService = new RoadStatusService();
            var obj = roadStatusService.GetRoadStatus("A2",TFLAPIUrl,APIKey);

            if(obj.errorInfo == null)
            Console.WriteLine("RoadId:{0}, DisplayName:{1}, StatusServeity:{2}, StatusSeverityDescription:{3}", obj.roadStatus.Id, obj.roadStatus.DisplayName,obj.roadStatus.StatusSeverity, obj.roadStatus.StatusSeverityDescription); 

            Console.ReadLine();

        }
    }
}