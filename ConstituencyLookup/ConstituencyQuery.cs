using ConstituencyLookup.LookupModels;
using ConstituencyLookup.Requests;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConstituencyLookup
{
    public class ConstituencyQuery
    {
        public ConstituencyResult GetConstitutencyByPostCode(string postcode)
        {
            var request = new PostcodeQueryRequest(postcode).BuildRequest();
            var task = Task.Run(() => new QueryClient().Execute(request));
            task.Wait();
            return JsonConvert.DeserializeObject<ConstituencyQueryResult>(task.Result).Result;
        }
    }
}
