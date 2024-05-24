using DataAccess.APIRequests;
using Newtonsoft.Json;
using UIModels;

namespace BusinessLogic.API
{
    public class DistanceMatrixBL
    {
        DistanceMatrixAPI db;
        public DistanceMatrixBL()
        {
            db = new DistanceMatrixAPI();
        }

        public async Task<DistanceCalc> GetDistance(string origin, string destination)
        {
            string jsonData = await db.GetDistance(origin, destination);

            return JsonConvert.DeserializeObject<DistanceCalc>(jsonData);
        }
    }
}
