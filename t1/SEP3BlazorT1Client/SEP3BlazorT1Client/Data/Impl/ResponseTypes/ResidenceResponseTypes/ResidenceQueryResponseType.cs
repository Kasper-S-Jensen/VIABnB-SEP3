using Newtonsoft.Json;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl.ResponseTypes.ResidenceResponseTypes
{
    public class ResidenceQueryResponseType
    {
        /// <summary>
        /// GraphQL response container containing the queried residence. 
        /// </summary>
        /// <value></value>
        [JsonProperty("residence")]
        public Residence Residence { get; set; }
        
        
    }
}