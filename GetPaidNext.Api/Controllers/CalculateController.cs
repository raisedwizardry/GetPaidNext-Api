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
        // GET api/calculate/paymentfrequency/biweeklypaydate/{date}
        [HttpGet]
        [Route("givendate/biweeklypaydate/{date}")]
        public ActionResult BiweeklyDate(string date)
        {
            var lastPaid = new Calculate.GivenDate(date);
            return Ok(new { results = lastPaid.BiweeklyNextPayDate() });
        }

        // GET api/calculate/givendate/weeklypaydate/{date}
        [HttpGet]
        [Route("givendate/weeklypaydate/{date}")]
        public ActionResult WeeklyDate(string date)
        {
            var lastPaid = new Calculate.GivenDate(date);
            return Ok(new { results = lastPaid.WeeklyNextPayDate() });
        }

        // GET api/calculate/givendate/biweeklypaythree/{date}
        [HttpGet]
        [Route("givendate/biweeklypaythree/{date}")]
        public ActionResult BiweeklyThreeMonth(string date)
        {
            var lastPaid = new Calculate.GivenDate(date);
            return Ok(new { results = "" });
        }
    }
}
