using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISpecialityDbAccess
    {
        Task<List<Speciality>> GetSpecialitiesAsync();
        Task<List<LawyerSpeciality>> GetLawyerSpecialitiesAsync();
    }
}
