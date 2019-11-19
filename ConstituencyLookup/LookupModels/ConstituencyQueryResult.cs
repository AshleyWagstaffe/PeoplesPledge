using Newtonsoft.Json;

namespace ConstituencyLookup.LookupModels
{
    internal class ConstituencyQueryResult
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("result")]
        public ConstituencyResult Result { get; set; }
    }
}
