namespace MangoMe.Services.EmailAPI.Data.Models
{
    public class EmailLogger
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime? EmailSent { get; set; }
    }
}
