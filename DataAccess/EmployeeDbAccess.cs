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
            try
            {
                return await db.Employees
                        .Include(t => t.LawyerTitle)
                        .ToListAsync();
            }
            catch (Exception)
            {
                return new List<Employee>();
            }
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            try
            {
                return await db.Employees
                        .Include(t => t.LawyerTitle)
                        .SingleOrDefaultAsync(e => e.PersonID == id);
            }
            catch (Exception)
            {
                return new Employee();
            }
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
