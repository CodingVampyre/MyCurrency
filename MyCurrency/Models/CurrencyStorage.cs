namespace MyCurrency.Models
{
    public class CurrencyStorage
    {
        public long Id { get; set; }
        public long AccountId;
        public Account Account;
        public long CurrencyId;
        public Currency Currency;
        public double Amount;
    }
}