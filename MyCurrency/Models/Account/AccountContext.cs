using Microsoft.EntityFrameworkCore;

namespace MyCurrency.Models.Account
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {
            
        }
        
        public DbSet<Account> Accounts { get; set; }
    }
}