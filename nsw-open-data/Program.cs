using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using nsw_open_data.Client;
using nsw_open_data.Models;
using nsw_open_data;
using System.IO;
using ChoETL;

namespace nsw_open_data
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main()
        {
            Console.Write("Input your name and press Enter key: ");
            string strInput = Console.ReadLine();
            NameVerifyService nameVerifyService = new NameVerifyService();

            if (!nameVerifyService.IsValidName(strInput))
            {
                Console.WriteLine("\nYou entered a number, which is not a valid name.");
            }

            Console.WriteLine("\nStarting async process to call NSW Open Data Transport API");
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update web service API endpoint in the following line.
            client.BaseAddress = new Uri("https://api.transport.nsw.gov.au/v1/live/hazards/incident/open");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/octet-stream"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("apikey", "j1zHbAwDsYNo4sR9FpInRVzIX8698p9JxomI");

            TransportAPI_client transportClient = new TransportAPI_client();
            

            try
            {
                // Get the current traffic incidents
                var incidents = await transportClient.GetCurrentTrafficIncidentsAsync(client.BaseAddress, client);

                var currentTrafficIncidents = JsonConvert.DeserializeObject<CurrentTrafficIncidentsModel>(incidents);

                
                StringBuilder stringBuilder = new StringBuilder();

                using (var incidentData = ChoJSONReader.LoadText(incidents)
                    .WithJSONPath("$..features[*]")
                    )
                {
                    using (var writer = new ChoCSVWriter(stringBuilder)
                        .WithFirstLineHeader()
                        .Configure(c => c.MaxScanRows = 1)
                        .Configure(c => c.ThrowAndStopOnMissingField = false)
                        )
                    {
                        writer.Write(incidentData);
                    }
                }


                File.AppendAllText("./output.csv", stringBuilder.ToString());

                Console.WriteLine("\nThe output from NSW Open Data Transport API is now in CSV flat file format. Filename: output.csv");
                //Console.WriteLine(currentTrafficIncidents.features);
                //Console.WriteLine(incidents.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nPress any key to exit.");
        }
    }
}
