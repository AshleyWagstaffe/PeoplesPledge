using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace ConstituencyLookup.LookupModels
{
    public class AddressQueryResult
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double MyProperty { get; set; }

        [JsonProperty("addresses")]
        public string[] Addresses { get; set; }

        [JsonIgnore]
        public IEnumerable<string> FirstLines => Addresses.Select(a => 
        {
            var components = a.Split(',');
            return $"{components[0]}, {components[1]}";
        });
    }
}
