namespace EmployeeApi.Models
{
    public class EmployeeExperience
    {
        public int ExperienceId { get; set; }
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal AnnualCTC { get; set; }
        public bool IsCurrentlyEmployed { get; set; }
        public string ExitReason { get; set; }
    }
}
