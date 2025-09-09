namespace CMCS_POE.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; } // Lecturer, Coordinator, Manager
    }
}

