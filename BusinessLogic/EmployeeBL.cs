using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.HelpServices;
using DataAccess;
using EntityModels;
using Interfaces;
using UIModels;

namespace BusinessLogic
{
    public class EmployeeBL
    {
        IEmployeeDbAccess dbAccess;
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

        public async Task<bool> UpdateEmployeeAsync(EmployeeUI employeeUI)
        {
            try
            {
                Employee employee = modelConverter.ConvertFromEmployeeUI(employeeUI);
                return await dbAccess.UpdateEmployeeAsync(employee);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
