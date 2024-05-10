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
        List<Employee> employees;
        public EmployeeDbAccess()
        {
            employees = new List<Employee>();
            db = new LawHouseDbContext();
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await db.Employees
                .Include(t => t.LawyerTitle)
                .ToListAsync();
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            return await db.Employees
                .Include(t => t.LawyerTitle)
                .SingleOrDefaultAsync(e => e.PersonID == id);
        }
    }
}
