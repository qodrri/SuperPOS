namespace SuperPOS.Models
{
    public class Member : BaseModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Point { get; set; } = 0;
    }
}
