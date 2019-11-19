using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ConstituencyLookup.LookupModels
{
    public class ConstituencyResult
    {
        [JsonProperty("parliamentary_constituency")]
        [Display(Name = "Constituency Name")]
        public string Name { get; set; }

        [JsonProperty("postcode")]
        [Display(Name = "Postcode")]
        public string PostCode { get; set; }
    }
}
