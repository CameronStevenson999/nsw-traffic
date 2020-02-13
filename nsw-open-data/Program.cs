using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using nsw_open_data.Client;

namespace nsw_open_data
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main()
        {
            Console.WriteLine("Starting async process to call NSW Open Data Transport API");
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://api.transport.nsw.gov.au/v1/live/hazards/incident/open");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/octet-stream"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("apikey", "j1zHbAwDsYNo4sR9FpInRVzIX8698p9JxomI");

            TransportAPI_client transportClient = new TransportAPI_client();
            var url = client.BaseAddress.ToString();

            try
            {
                // Get the current traffic incidents
                var incidents = await transportClient.GetCurrentTrafficIncidentsAsync(client.BaseAddress, client);

                Console.WriteLine(incidents.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
