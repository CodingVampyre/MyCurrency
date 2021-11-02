using System.ComponentModel.DataAnnotations;

namespace MyCurrency.Models
{
    public class CurrencyStorage
    {
        public long Id { get; set; }
        [Required]
        public long AccountId { get; set; }
        public Account Account { get; set; }
        [Required]
        public long CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public double Amount { get; set; } = 0;
    }
}