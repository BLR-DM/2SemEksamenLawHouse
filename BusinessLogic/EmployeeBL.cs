using BusinessLogic.HelpServices;
using BusinessLogic.Validation;
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
        PersonValidator pValidator;
        public EmployeeBL()
        {
            dbAccess = new EmployeeDbAccess();
            modelConverter = new ModelConverter();
            pValidator = new PersonValidator();
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
                try
                {
                    return modelConverter.ConvertFromEmployeeEntity(await dbAccess.GetEmployeeAsync(id));
                }
                catch (Exception)
                {
                    return new EmployeeUI();
                } 
            }
            return new EmployeeUI();
        }

        public async Task<bool> UpdateEmployeeAsync(EmployeeUI employeeUI)
        {
            if (!pValidator.ValidEmployee(employeeUI))
                return false;
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
