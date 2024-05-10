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
            List<Employee> employees = await dbAccess.GetEmployeesAsync();

            List<EmployeeUI> employeeUIs = new List<EmployeeUI>();

            if (employees.Count > 0)
            {
                foreach (Employee employee in employees)
                {
                    employeeUIs.Add(modelConverter.ConvertFromEmployeeEntity(employee));
                }
            }
            return employeeUIs;
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
