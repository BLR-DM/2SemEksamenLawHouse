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
        public EmployeeBL()
        {
            dbAccess = new EmployeeDbAccess();
        }

        public async Task GetEmployeesAsync()
        {
            await dbAccess.GetEmployeesAsync();
        }
    }
}
