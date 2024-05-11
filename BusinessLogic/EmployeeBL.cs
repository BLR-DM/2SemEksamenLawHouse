using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using EntityModels;
using UIModels;

namespace BusinessLogic
{
    public class EmployeeBL
    {
        EmployeeDbAccess dbAccess;
        ModelConverter modelConverter;
        public EmployeeBL()
        {
            dbAccess = new EmployeeDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<List<EmployeeUI>> GetEmployeesAsync()
        {
            try
            {
                List<Employee> employees = await dbAccess.GetEmployeesAsync();

                return employees.Select(modelConverter.ConvertFromEmployeeEntity).ToList();
            }
            catch (Exception)
            {
                return new List<EmployeeUI>();
            }
        }

        public async Task<EmployeeUI> GetEmployeeAsync(int id)
        {
            if (id > 0)
            {
                return modelConverter.ConvertFromEmployeeEntity(await dbAccess.GetEmployeeAsync(id)); 
            }
            return new EmployeeUI();
        }
    }
}
