using Newtonsoft.Json;

namespace Restful_Booker.Model.JsonModel
{
    public class BookingDates
    {
        [JsonProperty("checkin")]
        public DateOnly CheckIn { get; set; }

        [JsonProperty("checkout")]
        public DateOnly CheckOut { get; set; }
    }
}
