namespace ProductBackend.Models
{
    public class CustomerDetails
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
