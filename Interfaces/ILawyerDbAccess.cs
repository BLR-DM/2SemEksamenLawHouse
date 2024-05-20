using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILawyerDbAccess
    {
        Task<bool> CreateLawyerAsync(Lawyer lawyer);
        Task<Lawyer> GetLawyerAsync(int id);
        Task<Lawyer> GetLawyerWithCollectionsAsync(int id);
        Task<List<Lawyer>> GetLawyersAsync();
        Task<List<Lawyer>> GetLawyersWithCollectionsAsync();
        Task<bool> UpdateLawyerAsync(Lawyer lawyer);
        Task<bool> UpdateLawyerSpecialitiesAsync(List<LawyerSpeciality> lawyerSpecialities);
        Task<bool> DeleteLawyerSpecialitiesAsync(List<LawyerSpeciality> lawyerSpecialities);
    }
}
