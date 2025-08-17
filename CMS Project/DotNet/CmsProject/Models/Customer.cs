using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CmsProject.Models
{
    public class Customer
    {
        [Key]
        [Column("custId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // 👈 auto-increment identity
        public int CustId { get; set; }

        [Column("custName")]
        public string? CustName { get; set; }

        [Column("custUserName")]
        public string? CustUserName { get; set; }

        // Stored as VARBINARY(32) (SHA-256)
        [Column("custPassword", TypeName = "varbinary(32)")]
        [MaxLength(32)]
        public byte[]? CustPassword { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("mobileNo")]
        public string? MobileNo { get; set; }
    }
}
