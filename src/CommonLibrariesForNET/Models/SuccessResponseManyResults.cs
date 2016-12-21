using Newtonsoft.Json;

namespace Salesforce.Common.Models.Many
{ 
    public class SuccessResponseManyResults
    {
        [JsonProperty(PropertyName = "hasErrors")]
        public bool HasErrors;

        [JsonProperty(PropertyName = "results")]
        public SuccessResponseResult[] Results;
    }

    public class SuccessResponseResult
    {
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId;

        [JsonProperty(PropertyName = "id")]
        public string Id;
    }

   
}