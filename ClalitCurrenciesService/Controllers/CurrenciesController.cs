using ClalitCurrenciesService.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClalitCurrenciesService.Controllers
{
    [ApiController]
    [Route("api/currencies")]
    public class CurrenciesController : ControllerBase
    {
        private readonly ICurrenciesService _currenciesService;

        public CurrenciesController(ICurrenciesService currenciesService) => _currenciesService = currenciesService;

        [HttpGet]
        public IActionResult Get()
        {
            var currencies = _currenciesService.GetCurrencies(true);
            return Ok(currencies);
        }
    }
}