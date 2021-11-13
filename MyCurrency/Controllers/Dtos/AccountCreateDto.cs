using System.ComponentModel.DataAnnotations;

namespace MyCurrency.Models.Account
{
    public class AccountCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}