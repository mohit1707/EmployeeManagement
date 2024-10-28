namespace EmployeeApi.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeApi.Interface;
    using EmployeeApi.Models;
    using Microsoft.EntityFrameworkCore;

    namespace EmployeeManagementAPI.Data.Repositories
    {
        public class EmployeeExperienceRepository : IEmployeeExperienceRepository
        {
            private readonly EmployeeDbContext _context;

            public EmployeeExperienceRepository(EmployeeDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<EmployeeExperience>> GetAllAsync() => await _context.EmployeeExperiences.ToListAsync();

            public async Task<EmployeeExperience> GetByIdAsync(int id) => await _context.EmployeeExperiences.FindAsync(id);

            public async Task AddAsync(EmployeeExperience experience)
            {
                await _context.EmployeeExperiences.AddAsync(experience);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(EmployeeExperience experience)
            {
                _context.EmployeeExperiences.Update(experience);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var experience = await GetByIdAsync(id);
                if (experience != null)
                {
                    _context.EmployeeExperiences.Remove(experience);
                    await _context.SaveChangesAsync();
                }
            }

            public async Task<IEnumerable<EmployeeExperience>> GetExperiencesByEmployeeIdAsync(int employeeId) =>
                await _context.EmployeeExperiences.Where(e => e.EmployeeId == employeeId).ToListAsync();
        }
    }

}
