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
    public class ServiceBL
    {
        ModelConverter modelConverter;
        ServiceDbAccess dbAccess;
        public ServiceBL() 
        {
            modelConverter = new ModelConverter();
            dbAccess = new ServiceDbAccess();
        }

        public async Task<List<ServiceUI>> GetServicesAsync()
        {
            List<ServiceUI> services = new List<ServiceUI>();

            foreach(Service service in await dbAccess.GetServicesAsync())
            {
                services.Add(modelConverter.ConvertFromServiceEntity(service));
            }

            return services;
        }

        public async Task<List<ServiceUI>> GetServicesForCaseAsync(int id)
        {
            List<ServiceUI> serviceForCaseUI = new List<ServiceUI>();

            foreach(Service service in await dbAccess.GetServicesForCaseAsync(id))
            {
                serviceForCaseUI.Add(modelConverter.ConvertFromServiceEntity(service));
            }

            return serviceForCaseUI;
        }
    }
}
