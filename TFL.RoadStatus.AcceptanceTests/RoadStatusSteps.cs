using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFL.RoadStatus.Library;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace TFL.RoadStatus.AcceptanceTests
{
    [Binding]
    public class RoadStatusSteps
    {
        IRoadStatusService roadStatusService = new RoadStatusService();
        Response response;
        string roadID;
        string TFLAPIUrl;
        string APIKey;

        public RoadStatusSteps()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appconfig.json").Build();

            TFLAPIUrl = config["TFLAPIUrl"];
            APIKey = config["APIKey"];
        }
        
        [Given(@"a valid road ID '(.*)' is specified")]
        public void GivenAValidRoadIDIsSpecified(string roadId)
        {
            roadID = roadId;
        }


        [When(@"the client is run")]
        public void WhenTheClientIsRun()
        {
            response=roadStatusService.GetRoadStatus(roadID, TFLAPIUrl, APIKey);
        }

        [Then(@"the road displayName should be displayed as '(.*)'")]
        public void ThenTheRoadDisplayNameShouldBeDisplayedAs(string displayName)
        {
            Assert.IsNotNull(response.roadStatus);
            Assert.AreEqual(response.roadStatus.DisplayName, displayName);
        }

        [Then(@"the road statusSeverity should be displayed as '(.*)'")]
        public void ThenTheRoadStatusSeverityShouldBeDisplayedAs(string statusSeverity)
        {
            Assert.AreEqual(response.roadStatus.StatusSeverity, statusSeverity);
        }

        [Then(@"the road statusSeverityDescription should be displayed as '(.*)'")]
        public void ThenTheRoadStatusSeverityDescriptionShouldBeDisplayedAs(string statusSeverityDescription)
        {
            Assert.AreEqual(response.roadStatus.StatusSeverityDescription, statusSeverityDescription);
        }

        [Given(@"an invalid road ID '(.*)' is specified")]
        public void GivenAnInvalidRoadIDIsSpecified(string invalidRoadId)
        {
            roadID = invalidRoadId;
        }


        [Then(@"the application should return an informative error AS '(.*)'")]
        public void ThenTheApplicationShouldReturnAnInformativeErrorAS(string informativeError)
        {
            Assert.IsNotNull(response.errorInfo);
            Assert.AreEqual(response.errorInfo.Message, informativeError);
        }

    }
}
