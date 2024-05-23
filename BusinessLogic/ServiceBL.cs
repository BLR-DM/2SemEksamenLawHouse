using BusinessLogic.HelpServices;
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
    public class ServiceBL
    {
        ModelConverter modelConverter;
        IServiceDbAccess dbAccess;
        public ServiceBL() 
        {
            modelConverter = new ModelConverter();
            dbAccess = new ServiceDbAccess();
        }

        public async Task<bool> CreateServiceAsync(ServiceUI serviceUI)
        {
            Service service = modelConverter.ConvertFromServiceUI(serviceUI);
            return await dbAccess.CreateServiceAsync(service);
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

        public async Task<ServiceUI> GetServiceAsync(int id)
        {
            Service service = await dbAccess.GetServiceAsync(id);
            ServiceUI serviceUI = modelConverter.ConvertFromServiceEntity(service);
            return serviceUI;
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

        public async Task<bool> UpdateServiceAsync(ServiceUI serviceUI)
        {
            Service serviceToUpdate = modelConverter.ConvertFromServiceUI(serviceUI);
            return await dbAccess.UpdateServiceAsync(serviceToUpdate);
        }

        public async Task<bool> DeleteServiceAsync(ServiceUI serviceUI)
        {
            Service service = modelConverter.ConvertFromServiceUI(serviceUI);
            return await dbAccess.DeleteServiceAsync(service);
        }
    }
}
