using ConstituencyLookup.LookupModels;
using ConstituencyLookup.Requests;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace ConstituencyLookup
{
    public class AddressQuery
    {
        public IEnumerable<AddressResult> GetAddressesByPostCode(string postcode)
        {
            var request = new AddressQueryRequest(postcode).BuildRequest();
            var task = Task.Run(() => new QueryClient().Execute(request));
            task.Wait();
            AddressQueryResult addressQueryResult = JsonConvert.DeserializeObject<AddressQueryResult>(task.Result);
            return addressQueryResult.Addresses.Select(a => new AddressResult() { FirstLine = a, Postcode = postcode });
        }
    }
}
