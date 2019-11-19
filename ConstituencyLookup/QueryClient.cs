using System.Net.Http;
using System.Threading.Tasks;

namespace ConstituencyLookup
{
    internal class QueryClient
    {
        public async Task<string> Execute(HttpRequestMessage requestMessage)
        {
            try
            {
                using(var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.SendAsync(requestMessage);
                    string body = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        return body;
                    }
                    else
                    {
                        throw new HttpRequestException($"failed to get request body data, status { response.StatusCode }, body { body }");
                    }
                }
            }catch(HttpRequestException ex)
            {
                // do logging here
                throw;
            }
        }
    }
}
