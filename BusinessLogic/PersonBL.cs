using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using EntityModels;

namespace BusinessLogic
{
    public class PersonBL
    {
        PersonDbAccess dbAccess;
        ModelConverter modelConverter;
        public PersonBL()
        {
            dbAccess = new PersonDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<PersonUI> GetPersonAsync(int id)
        {
            Person person = await dbAccess.GetPersonAsync(id);

            if (person is Client)
            {
                PersonUI personUI = new ClientBL().GetClientAsync(person.PersonID);
                return new PersonUI();
            }

            return new PersonUI();
        }
    }
}
