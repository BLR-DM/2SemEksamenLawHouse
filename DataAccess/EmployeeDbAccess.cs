using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EmployeeDbAccess
    {
        LawHouseDbContext db;
        List<Employee> e;
        public EmployeeDbAccess()
        {
            e = new List<Employee>();
            db = new LawHouseDbContext();
        }

        public async Task GetEmployeesAsync()
        {
            e = await db.Employees
                .ToListAsync();
        }
    }
}
