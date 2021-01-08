﻿using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain;
using Api.Services;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [ApiController]
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
        public JsonResult AddCoin(ICoin coin)
        {

            return Json("Your Coin has been added to the Jar!");
        }

        [Route("total-coins")]
        [HttpGet]
        public JsonResult GetTotalCoins()
        {
            var result = _coinJarService.GetTotalAmount();

            return Json("Total Amount in Coin Jar: " + result);
        }

        [Route("reset-coin-jar")]
        [HttpPost]
        public JsonResult Reset()
        {
            _coinJarService.Reset();

            return Json("Coin Jar has been reset!");
        }
    }
}
