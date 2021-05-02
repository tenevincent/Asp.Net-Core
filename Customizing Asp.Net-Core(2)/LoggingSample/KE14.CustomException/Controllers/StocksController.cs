using KE14.CustomException.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KE14.CustomException.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StocksController : ControllerBase
    {
        private readonly IStocksService _stocksService;

        public StocksController(IStocksService stocksService)
        {
            _stocksService = stocksService ?? throw new ArgumentNullException(nameof(stocksService));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var stocks = _stocksService.GetAllStocks();
            return new OkObjectResult(stocks);
        }

        [HttpGet]
        [Route("{stockId}")]
        public IActionResult GetById(Guid stockId)
        {
            var stock = _stocksService.GetStock(stockId);
            return new OkObjectResult(stock);
        }
    }
}
