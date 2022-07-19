namespace ClalitCurrenciesService.Services
{
    public interface ICurrenciesService
    {
        public List<Currency>? GetCurrencies(bool isNegativeChange);
    }
}
