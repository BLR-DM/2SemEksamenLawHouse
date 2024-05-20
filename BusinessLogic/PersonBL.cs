using DataAccess;
using UIModels;
using EntityModels;
using Interfaces;

namespace BusinessLogic
{
    public class PersonBL
    {
        IPersonDbAccess dbAccess;
        ModelConverter modelConverter;
        public PersonBL()
        {
            dbAccess = new PersonDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<PersonUI> GetPersonAsync(int id)
        {
            try
            {
                Person person = await dbAccess.GetPersonAsync(id);

                if (person != null)
                {
                    if (person is Client)
                    {
                        ClientUI clientUI = await new ClientBL().GetClientAsync(person.PersonID);
                        return clientUI;
                    }
                    if (person is Lawyer)
                    {
                        LawyerUI lawyerUI = await new LawyerBL().GetLawyerWithCollectionsAsync(person.PersonID);
                        return lawyerUI;
                    }
                    if (person is Employee)
                    {
                        EmployeeUI employeeUI = await new EmployeeBL().GetEmployeeAsync(person.PersonID);
                        return employeeUI;
                    }
                }
                return new PersonUI();
            }
            catch (Exception)
            {
                return new PersonUI();
            }
        }
    }
}
