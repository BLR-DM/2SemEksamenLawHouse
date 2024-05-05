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
                ClientUI clientUI = await new ClientBL().GetClientAsync(person.PersonID);
                return clientUI;
            }
            if(person is Lawyer)
            {
                LawyerUI lawyerUI = await new LawyerBL().GetLawyerAsync(person.PersonID);
                return lawyerUI;
            }

            return null;
        }
    }
}
