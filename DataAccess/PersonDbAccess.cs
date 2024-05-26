using EntityModels;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class PersonDbAccess : IPersonDbAccess
    {
        LawHouseDbContext db;
        public PersonDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            try
            {
                return await db.Persons.FirstOrDefaultAsync(p => p.LoginDetailsID == id);
            }
            catch (Exception)
            {
                return new Person();
            }
        }
    }
}
