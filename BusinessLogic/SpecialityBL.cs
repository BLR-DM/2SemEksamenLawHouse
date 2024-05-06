using DataAccess;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace BusinessLogic
{
    public class SpecialityBL
    {
        ModelConverter modelConverter;
        SpecialityDbAccess dbAccess;
        public SpecialityBL() 
        { 
            modelConverter = new ModelConverter();
            dbAccess = new SpecialityDbAccess();
        }

        public async Task<List<SpecialityUI>> GetSpecialitiesAsync()
        {
            List<SpecialityUI> specialityUIs = new List<SpecialityUI>();

            foreach(Speciality speciality in await dbAccess.GetSpecialitiesAsync())
            {
                specialityUIs.Add(modelConverter.ConvertFromSpecialityEntity(speciality));
            }

            return specialityUIs;
        }

        public async Task<List<LawyerSpecialityUI>> GetLawyerSpecialities()
        {
            List<LawyerSpecialityUI> lawyerSpecialityList = new List<LawyerSpecialityUI>();

            foreach(LawyerSpeciality lawyerSpeciality in await dbAccess.GetLawyerSpecialitiesAsync())
            {
                lawyerSpecialityList.Add(modelConverter.ConvertFromLawyerSpecialityEntity(lawyerSpeciality));
            }

            return lawyerSpecialityList;
        }


    }
}
