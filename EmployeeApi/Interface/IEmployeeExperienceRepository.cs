using EmployeeApi.Models;

namespace EmployeeApi.Interface
{
    public interface IEmployeeExperienceRepository : IRepository<EmployeeExperience>
    {
        Task<IEnumerable<EmployeeExperience>> GetExperiencesByEmployeeIdAsync(int employeeId);
    }

}
