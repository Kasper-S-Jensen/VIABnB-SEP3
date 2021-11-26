using Newtonsoft.Json;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data.Impl.ResponseTypes
{
    public class CreateRuleResponseType
    {
        [JsonProperty("createNewRule")] public Rule NewRule { get; set; }
    }
}