using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using nsw_open_data.Models;

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
