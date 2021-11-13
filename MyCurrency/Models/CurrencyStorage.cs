using System.ComponentModel.DataAnnotations;
using MyCurrency.Models.Account;

namespace MyCurrency.Models
{
    public class CurrencyStorage
    {
        public long Id { get; set; }
        [Required]
        public long AccountId { get; set; }
        public Account.Account Account { get; set; }
        [Required]
        public long CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public double Amount { get; set; } = 0;
    }
}