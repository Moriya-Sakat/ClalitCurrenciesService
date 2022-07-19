using Newtonsoft.Json;
using System.Xml;

namespace ClalitCurrenciesService.Services
{
    public class CurrenciesService : ICurrenciesService
    {
        private readonly ILogger<CurrenciesService> _logger;

        public CurrenciesService(ILogger<CurrenciesService> logger) => _logger = logger;

        public List<Currency>? GetCurrencies(bool isNegativeChange)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("https://www.boi.org.il/currency.xml");

                string jsonText = JsonConvert.SerializeXmlNode(doc);
                var currencyData = JsonConvert.DeserializeObject<CurrencyData>(jsonText);

                var data = currencyData?.Currencies.Currency;

                if (isNegativeChange)
                {
                    return data?.Where(x => double.TryParse(x.Change, out double change) && change < 0).ToList();
                }

                return data;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to get currencies");
                throw;
            }
        }
    }
}
