using Microsoft.EntityFrameworkCore;

namespace MyCurrency.Models
{
    public class CurrencyStorageContext : DbContext
    {
        public CurrencyStorageContext(DbContextOptions<CurrencyStorageContext> options) : base(options)
        {
            
        }
        
        public DbSet<CurrencyStorage> CurrencyStorages { get; set; }
    }
}