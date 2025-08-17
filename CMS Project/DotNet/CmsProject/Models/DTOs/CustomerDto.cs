namespace CmsProject.Models.DTOs
{
    public class CustomerDto
    {
        public int CustId { get; set; }
        public string? CustName { get; set; }
        public string? CustUserName { get; set; }
        public string? Password { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
    }
}
