using BusinessLogic.Validation;

namespace BusinessLogic.HelpServices
{
    public static class GetCityFromPostalCode
    {
        public static string SetCityFromPostalCode(string postal)
        {
            PersonValidator pValidator = new PersonValidator();

            if (!pValidator.ValidPostalCode(postal))
                return "-";

            string location = "Resources\\postnumre.csv";

            try
            {
                string[] lines = File.ReadAllLines(location);

                foreach (string line in lines.Skip(1))
                {
                    string[] temp = line.Split(',');
                    if (temp[0] == postal)
                    {
                        return temp[1];
                    }
                }
                return "-";
            }
            catch (Exception)
            {
                return "-";
            } 
        }
    }
}
