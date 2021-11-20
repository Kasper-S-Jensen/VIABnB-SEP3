using Newtonsoft.Json;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl.ResponseTypes
{
    public class HostResponseType
    {
        [JsonProperty("Host")]
        public Host Host { get; set; }
    }
}