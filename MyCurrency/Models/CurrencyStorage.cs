namespace MyCurrency.Models
{
    public class CurrencyStorage
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public Account Account { get; set; }
        public long CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public double Amount { get; set; }
    }
}