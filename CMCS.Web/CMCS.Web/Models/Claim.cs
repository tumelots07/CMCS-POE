namespace CMCS_POE.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public int LecturerId { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public double TotalHours { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
