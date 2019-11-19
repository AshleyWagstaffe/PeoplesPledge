using System;
using System.Net.Http;

namespace ConstituencyLookup.Requests
{
    internal class AddressQueryRequest
    {
        public const string API_KEY = "x9b9ZNPHu02K1ghCpkqWMQ22112";
        public const string URL = "https://api.getaddress.io/find/{0}?api-key={1}";

        private readonly string postcode;

        public AddressQueryRequest(string postcode)
        {
            this.postcode = postcode;
        }

        public HttpRequestMessage BuildRequest()
        {
            Uri uri = new Uri(string.Format(URL, this.postcode, API_KEY));
            return new HttpRequestMessage(HttpMethod.Get, uri);
        }
    }
}
