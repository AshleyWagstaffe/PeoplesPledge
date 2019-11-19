using System;
using System.Net.Http;

namespace ConstituencyLookup.Requests
{
    internal class PostcodeQueryRequest
    {
        public const string URL = "https://postcodes.io/postcodes/{0}";

        private readonly string postcode;

        public PostcodeQueryRequest(string postcode)
        {
            this.postcode = postcode;
        }

        public HttpRequestMessage BuildRequest()
        {
            Uri uri = new Uri(string.Format(URL, this.postcode));
            return new HttpRequestMessage(HttpMethod.Get, uri);
        }
    }
}
