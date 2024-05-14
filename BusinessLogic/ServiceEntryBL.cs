using DataAccess;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace BusinessLogic
{
    public class ServiceEntryBL
    {
        ModelConverter modelConverter;
        ServiceEntryDbAccess dbAccess;
        public ServiceEntryBL()
        {
            modelConverter = new ModelConverter();
            dbAccess = new ServiceEntryDbAccess();
        }

        public async Task<bool> CreateServiceEntryAsync(ServiceEntryUI serviceEntryUI)
        {
            return await dbAccess.CreateServiceEntryAsync(modelConverter.ConvertFromServiceEntryUI(serviceEntryUI));
        }

        public async Task<List<ServiceEntryUI>> GetServiceEntryUIAsync(int id)
        {
            List<ServiceEntryUI> serviceEntriesUI = new List<ServiceEntryUI>();

            foreach (ServiceEntry serviceEntry in await dbAccess.GetServiceEntriesAsync(id)) 
            {
                serviceEntriesUI.Add(modelConverter.ConvertFromServiceEntryEntity(serviceEntry));
            }

            return serviceEntriesUI;
        }
    }
}
