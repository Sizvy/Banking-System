using System.ComponentModel.DataAnnotations;

namespace Bank.Model
{
    public class Account
    {
        [Key]
        [Required]
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public string? AccountType { get; set;}
        public decimal? Balance { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public string? PhoneNo { get; set; }
    }
}
