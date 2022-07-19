namespace ClalitCurrenciesService
{
    public class Currencies
    {
        public string LastUpdate { get; set; } = "";
        public List<Currency> Currency { get; set; } = null!;
    }

    public class CurrencyData
    {
        public Currencies Currencies { get; set; } = null!;
    }
}
