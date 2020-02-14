using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace nsw_open_data.Client
{
    public class TransportAPI_client
    {
        //static HttpClient client = new HttpClient();
        public async Task<string> GetCurrentTrafficIncidentsAsync(Uri path, HttpClient transportApiClient)
        {
            string incidents = null;

            HttpResponseMessage response = await transportApiClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                incidents = await response.Content.ReadAsStringAsync();
            }
            return incidents;
        }
    }
}
