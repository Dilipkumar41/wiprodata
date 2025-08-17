namespace CmsProject.Models.DTOs
{
    public class CustomerCreateDto
    {
        public int CustId { get; set; }                 // required (not identity)
        public string? CustName { get; set; }
        public string? CustUserName { get; set; }
        public string? Password { get; set; }           // plain text from client
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
    }
}
