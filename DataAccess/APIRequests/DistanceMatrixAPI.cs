﻿namespace DataAccess.APIRequests
{
    public class DistanceMatrixAPI
    {
        HttpClient client;

        public DistanceMatrixAPI()
        {
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<string> GetDistance(string origin, string destination)
        {
            string apiKey = "AIzaSyCXTSVjkcMqSYbvrNIv1SFBHguuzwsfHCs";

            string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=metric&origins=" +
                $"{origin}&destinations={destination}&key={apiKey}";

            HttpResponseMessage response = await client.GetAsync(url);

            string jsonData = await response.Content.ReadAsStringAsync();

            return jsonData;
        }
    }
}