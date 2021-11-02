using System.ComponentModel.DataAnnotations;

namespace MyCurrency.Models
{
    public class Currency
    {
        public long Id { get; set; }
        [Required]
        public string CurrencyName { get; set; }
    }
}