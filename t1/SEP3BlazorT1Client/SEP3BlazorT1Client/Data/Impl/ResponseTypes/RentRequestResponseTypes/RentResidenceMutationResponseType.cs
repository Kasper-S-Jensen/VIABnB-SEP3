using Newtonsoft.Json;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl.ResponseTypes.RentRequestResponseTypes
{
    public class RentResidenceMutationResponseType
    {
        [JsonProperty("rentResidence")]
        public RentRequest RentResidence { get; set; }
    }
}