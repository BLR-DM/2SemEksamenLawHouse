using BusinessLogic.Validation;
using DataAccess;
using Interfaces;

namespace BusinessLogic
{
    public class LoginBL
    {
        ILoginDbAccess dbAccess;
        PersonValidator pValidator;

        public LoginBL()
        {
            dbAccess = new LoginDbAccess();
            pValidator = new PersonValidator();
        }

        public async Task<int> CheckUsernameAndPasswordAsync(string username, string password)
        {
            if (!pValidator.ValidEmail(username) || pValidator.ValidPassword(password))
                return 0;

            try
            {
                return await dbAccess.CheckUsernameAndPasswordAsync(username, password);
            }
            catch (Exception)
            {
                return 0;
            } 
        }

        public async Task<string> RetrievePasswordAsync(string username)
        {
            // Denne funktion er en simulation
            if (pValidator.ValidEmail(username))
                return "*Invalid Email Format*";

            try
            {
                return await dbAccess.RetrievePasswordAsync(username);
            }
            catch (Exception)
            {
                return "*Not Found*";
            }
        }
    }
}
