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
    public class ServicePriceTypeBL
    {
        IServicePriceTypeDbAccess dbAccess;
        ModelConverter modelConverter;

        public ServicePriceTypeBL()
        {
            dbAccess = new ServicePriceTypeDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<List<ServicePriceTypeUI>> GetServicePriceTypeAsync()
        {
            List<ServicePriceTypeUI> servicePriceTypeUIs = new List<ServicePriceTypeUI>();

            foreach(ServicePriceType servicePriceType in await dbAccess.GetServicePriceTypesAsync())
            {
                servicePriceTypeUIs.Add(modelConverter.ConvertFromServicePriceTypeEntity(servicePriceType));
            }

            return servicePriceTypeUIs;
        }


    }
}
