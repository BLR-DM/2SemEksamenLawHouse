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

        public async Task<DistanceMatrix> GetDistance(string origin, string destination)
        {
            string jsonData = await db.GetDistanceAsync(origin, destination);

            return JsonConvert.DeserializeObject<DistanceMatrix>(jsonData);
        }
    }
}
