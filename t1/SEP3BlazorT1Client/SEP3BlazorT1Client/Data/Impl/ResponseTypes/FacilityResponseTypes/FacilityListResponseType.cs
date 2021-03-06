using System.Collections.Generic;
using Newtonsoft.Json;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl.ResponseTypes.FacilityResponseTypes
{
    public class FacilityListResponseType
    {
        [JsonProperty("allFacilities")]
        public IEnumerable<Facility> Facilities { get; set; }
    }
}