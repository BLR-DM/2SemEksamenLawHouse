using DataAccess;
using EntityModels;
using Interfaces;
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
        ISpecialityDbAccess dbAccess;
        public SpecialityBL() 
        { 
            modelConverter = new ModelConverter();
            dbAccess = new SpecialityDbAccess();
        }

        public async Task<bool> CreateSpecialityAsync(SpecialityUI specialityUI)
        {
            Speciality speciality = modelConverter.ConvertFromSpecialityUI(specialityUI);
            return await dbAccess.CreateSpecialityAsync(speciality);
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

        public async Task<List<LawyerSpecialityUI>> GetLawyerSpecialitiesAsync()
        {
            List<LawyerSpecialityUI> lawyerSpecialityList = new List<LawyerSpecialityUI>();

            foreach(LawyerSpeciality lawyerSpeciality in await dbAccess.GetLawyerSpecialitiesAsync())
            {
                lawyerSpecialityList.Add(modelConverter.ConvertFromLawyerSpecialityEntity(lawyerSpeciality));
            }

            return lawyerSpecialityList;
        }

        public async Task<bool> UpdateSpecialityAsync(SpecialityUI specialityUI)
        {
            Speciality speciality = modelConverter.ConvertFromSpecialityUI(specialityUI);
            return await dbAccess.UpdateSpecialityAsync(speciality);
        }

        public async Task<bool> DeleteSpecialityAsync(SpecialityUI specialityUI)
        {
            Speciality speciality = modelConverter.ConvertFromSpecialityUI(specialityUI);
            return await dbAccess.DeleteSpecialityAsync(speciality);
        }

    }
}
