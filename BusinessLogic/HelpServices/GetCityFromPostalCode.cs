using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.HelpServices
{
    public static class GetCityFromPostalCode
    {
        public static string SetCityFromPostalCode(int postal)
        {
            string location = "Resources\\postnumre.csv";

            try
            {
                string[] lines = File.ReadAllLines(location);

                foreach (string line in lines.Skip(1))
                {
                    string[] temp = line.Split(',');
                    if (int.Parse(temp[0]) == postal)
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
