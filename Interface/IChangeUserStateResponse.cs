using System;
using Newtonsoft.Json;

namespace PostRequest.Interface
{
    public class IChangeUserStateResponse
    {
        [JsonProperty("method")]
        public string method { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("from")]
        public string from { get; set; }

        [JsonProperty("to")]
        public string to { get; set; }
    }
}