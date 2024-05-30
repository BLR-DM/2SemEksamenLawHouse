using System.Configuration;

namespace DataAccess.APIRequests
{
    public class DistanceMatrixAPI
    {
        HttpClient client;
        string apiKey;

        public DistanceMatrixAPI()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            apiKey = ConfigurationManager.AppSettings["GoogleApiKey"];
        }

        public async Task<string> GetDistanceAsync(string origin, string destination)
        {
            string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=metric&origins=" +
                $"{origin}&destinations={destination}&key={apiKey}";

            HttpResponseMessage response = await client.GetAsync(url);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
