using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class PersonDbAccess
    {
        LawHouseDbContext db;
        public PersonDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            return await db.Persons.FirstOrDefaultAsync(p => p.LoginDetailsID == id);
        }
    }
}
