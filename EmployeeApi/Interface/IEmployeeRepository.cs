using EmployeeApi.Models;

namespace EmployeeApi.Interface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<Employee> GetByEmailAsync(string email);
        Task<Employee> GetByMobileAsync(string mobileNumber);
    }

}
