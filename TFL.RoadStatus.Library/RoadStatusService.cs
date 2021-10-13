using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using System.Threading.Tasks;



namespace TFL.RoadStatus.Library
{
    public class RoadStatusService : IRoadStatusService
    {

        public Response GetRoadStatus(string roadId, string TFLAPIUrl, string APIKey)
        {        

            string url = string.Concat(TFLAPIUrl, roadId, "?app_key=", APIKey);

            Response response = new Response();
            try
            {

                using (var client = new HttpClient())
                {

                    var responseTask = client.GetAsync(url);
                    //responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        var readTask = result.Content.ReadAsAsync<RoadStatus[]>();
                        //readTask.Wait();

                        var roadStatuses = readTask.Result;

                        response.roadStatus = roadStatuses[0];

                    }
                    else
                    {
                        var readTask = result.Content.ReadAsAsync<ErrorInfo>();

                        response.errorInfo = readTask.Result;

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return response;
        }
   
    }
}
