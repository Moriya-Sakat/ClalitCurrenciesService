namespace ClalitCurrenciesService
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Unit { get; set; } = String.Empty;
        public string CurrencyCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public string Rate { get; set; } = String.Empty;
        public string Change { get; set; } = String.Empty;
    }
}