namespace EmployeeApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
