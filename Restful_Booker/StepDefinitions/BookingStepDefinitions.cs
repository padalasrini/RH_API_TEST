using Newtonsoft.Json;
using Restful_Booker.Model.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using Restful_Booker.Features;
using System.Globalization;
using System.Net;
using Xunit.Abstractions;

namespace Restful_Booker.StepDefinitions
{
    [Binding]
    public class BookingStepDefinitions
    {
        private readonly string Url = "https://restful-booker.herokuapp.com/booking";
        private readonly ScenarioContext scenarioContext;
        public BookingStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I create a room booking using the CreateBooking API")]
        public void GivenICreateARoomBookingUsingTheCreateBookingAPI(Table table)
        {
            var bookingDetailsTable = table.Rows[0];
            BookingDetails bookingDetails = new()
            {
                FirstName = bookingDetailsTable["firstname"],
                LastName = bookingDetailsTable["lastname"],
                TotalPrice = int.Parse(bookingDetailsTable["totalprice"]),
                DepositPaid = bool.Parse(bookingDetailsTable["depositpaid"]),
                BookingDates = new BookingDates
                {
                    CheckIn = DateOnly.Parse(bookingDetailsTable["checkin"]),
                    CheckOut = DateOnly.Parse(bookingDetailsTable["checkout"])
                },
                AdditionalNeeds = bookingDetailsTable["additionalneeds"]
            };
            var jsonData = JsonConvert.SerializeObject(bookingDetails);

            using HttpClient httpClient = new();

            using HttpRequestMessage httpRequestMessage = new();
            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri(Url);
            httpRequestMessage.Headers.Add("Accept", "application/json");
            httpRequestMessage.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using HttpResponseMessage httpResponseMessage = httpClient.SendAsync(httpRequestMessage).Result;
            RestResponse restResponse = new((int)httpResponseMessage.StatusCode, httpResponseMessage.Content.ReadAsStringAsync().Result);

            Assert.True(restResponse.StatusCode == 200, $"Expected status code 200, but got {restResponse.StatusCode}.");

            var bookingResponse = JsonConvert.DeserializeObject<BookingResponse>(restResponse.ResponseContent);

            Assert.True(bookingResponse != null, "Booking Response is Null");

            scenarioContext["BookingID"] = bookingResponse.BookingId;
        }

        [Then(@"I verify the booking is successful using GetBooking API")]
        public void ThenIVerifyTheBookingIsSuccessfulUsingGetBookingAPI()
        {
            var id = scenarioContext["BookingID"];

            using HttpClient httpClient = new();

            using HttpRequestMessage httpRequestMessage = new();
            httpRequestMessage.RequestUri = new Uri(Url + "/" + id);
            httpRequestMessage.Method = HttpMethod.Get;
            httpRequestMessage.Headers.Add("Accept", "application/json");

            using HttpResponseMessage httpResponseMessage = httpClient.SendAsync(httpRequestMessage).Result;
            RestResponse restResponse = new((int)httpResponseMessage.StatusCode, httpResponseMessage.Content.ReadAsStringAsync().Result);

            Assert.True(restResponse.StatusCode == 200, $"Booking is Unsuccessful, Expected status code 200, but got {restResponse.StatusCode}.");

            var bookingResponse = JsonConvert.DeserializeObject<BookingDetails>(restResponse.ResponseContent);

            Assert.True(bookingResponse != null, "Booking Response is Null");
        }

    }
}
