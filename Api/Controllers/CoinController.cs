using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Api.Domain;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/coin-jar")]
    public class CoinController : Controller
    {

        private readonly ICoinJar _coinJarService;
        private readonly Context _dbContext;

        public CoinController(ICoinJar coinJarService)
        {
            _coinJarService = coinJarService;
        }

        [Route("add-coin")]
        [HttpPost]
        public void AddCoin(ICoin coin)
        {
            
        }

        [Route("get-total-coins")]
        [HttpGet]
        public decimal GetTotalAmount()
        {
            return 0;
        }

        [Route("reset-coin-jar")]
        [HttpPost]
        public void Reset()
        {

        }
    }
}
