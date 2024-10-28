using EmployeeApi.Interface;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeExperienceController : ControllerBase
    {
        private readonly IEmployeeExperienceRepository _experienceRepository;

        public EmployeeExperienceController(IEmployeeExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        [HttpGet("employee/{employeeId}")]
        public async Task<IActionResult> GetExperiencesByEmployeeId(int employeeId) =>
            Ok(await _experienceRepository.GetExperiencesByEmployeeIdAsync(employeeId));

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeExperience experience)
        {
            await _experienceRepository.AddAsync(experience);
            return CreatedAtAction(nameof(GetExperiencesByEmployeeId), new { employeeId = experience.EmployeeId }, experience);
        }
    }
}
