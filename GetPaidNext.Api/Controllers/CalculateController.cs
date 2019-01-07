using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GetPaidNext.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        // GET api/calculate/weekly/{date}
        [HttpGet]
        [Route("weekly/{date}")]
        public ActionResult GetWeeklyDate(string date)
        {
            var weekly = new Calculate.Weekly();
            return Ok(new { results = weekly.NextPayDate(date) });
        }

        // GET api/calculate/biweekly/{date}
        [HttpGet]
        [Route("biweekly/{date}")]
        public ActionResult GetBiweeklyDate(string date)
        {
            var biweekly = new Calculate.Biweekly();
            return Ok(new { results = biweekly.NextPayDate(date) });
        }
    }
}
