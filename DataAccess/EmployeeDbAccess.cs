using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EmployeeDbAccess : IEmployeeDbAccess
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

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                db.Employees.Update(employee);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
