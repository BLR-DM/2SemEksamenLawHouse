using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILawyerTitleDbAccess
    {
        Task<bool> CreateLawyerTitleAsync(LawyerTitle lawyerTitle);
        Task<List<LawyerTitle>> GetLawyerTitles();
        Task<bool> UpdateLawyerTitleAsync(LawyerTitle lawyerTitle);
        Task<bool> DeleteLawyerTitleAsync(LawyerTitle lawyerTitle);
    }
}
