using DataAccess;
using EntityModels;
using Interfaces;
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
        IServiceEntryDbAccess dbAccess;
        public ServiceEntryBL()
        {
            modelConverter = new ModelConverter();
            dbAccess = new ServiceEntryDbAccess();
        }

        public async Task<bool> CreateServiceEntryAsync(ServiceEntryUI serviceEntryUI)
        {
            return await dbAccess.CreateServiceEntryAsync(modelConverter.ConvertFromServiceEntryUI(serviceEntryUI));
        }

        public async Task<List<ServiceEntryUI>> GetServiceEntryUIAsync(int CaseServiceID)
        {
            List<ServiceEntryUI> serviceEntriesUI = new List<ServiceEntryUI>();

            foreach (ServiceEntry serviceEntry in await dbAccess.GetServiceEntriesAsync(CaseServiceID)) 
            {
                serviceEntriesUI.Add(modelConverter.ConvertFromServiceEntryEntity(serviceEntry));
            }

            return serviceEntriesUI;
        }
    }
}
