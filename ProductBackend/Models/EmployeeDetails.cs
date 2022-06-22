namespace ProductBackend.Models
{
    public class EmployeeDetails
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public int StoreId { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string Role { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
