using System.ComponentModel.DataAnnotations;

namespace MyCurrency.Models
{
    public class Account
    {
        public long Id { get; set; }
        [Required]
        public string AccountOwnerName { get; set; }
    }
}