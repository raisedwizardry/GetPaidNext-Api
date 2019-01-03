using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GetPaidNext.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        // GET api/calculate/weekly
        [HttpGet]
        [Route("weekly/{date}")]
        public ActionResult GetWeeklyDate(String date)
        {
            return Ok(Calculate.Weekly.GiveNextDate(date));
        }

        // GET api/calculate/biweekly
        [HttpGet]
        [Route("biweekly/{date}")]
        public ActionResult GetBiweeklyDate(String date)
        {
            return Ok(Calculate.Biweekly.GiveNextDate(date));
        }
    }
}
