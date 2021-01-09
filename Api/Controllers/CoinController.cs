using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Api.Models;

namespace Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/coin-jar")]
    public class CoinController : Controller
    {
        private readonly ICoinJar _coinJarService;

        public CoinController(ICoinJar coinJarService)
        {
            _coinJarService = coinJarService;
        }
      
        [Route("add-coin")]
        [HttpPost]
        public JsonResult AddCoin([FromBody] CoinViewModel coin)
        {
            _coinJarService.AddCoin(coin);

            return Json("Your Coin has been added to the Jar!");
        }

        [Route("total-coins")]
        [HttpGet]
        public JsonResult GetTotalCoins()
        {
            var result = _coinJarService.GetTotalAmount();

            return Json("Total Amount in Coin Jar: $" + result/100);
        }

        [Route("reset-coin-jar")]
        [HttpGet]
        public JsonResult Reset()
        {
            _coinJarService.Reset();

            return Json("Coin Jar has been reset!");
        }
    }
}
