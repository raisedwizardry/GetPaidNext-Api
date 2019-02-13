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
        // GET api/calculate/givendate/monthlypaydate/{date}
        [HttpGet]
        [Route("givendate/monthlypaydate/{date}")]
        public ActionResult MonthlyDate(string date)
        {
            var lastPaid = new Calculate.Monthly(date);
            return Ok(new { results = lastPaid.NextPayDate() });
        }

        // GET api/calculate/givendate/monthlypaydate/{date}
        [HttpGet]
        [Route("givendate/bimonthlypaydate/{date}")]
        public ActionResult BimonthlyDate(string date)
        {
            var lastPaid = new Calculate.Bimonthly(date);
            return Ok(new { results = lastPaid.NextPayDate() });
        }

        // GET api/calculate/givendate/biweeklypaydate/{date}
        [HttpGet]
        [Route("givendate/biweeklypaydate/{date}")]
        public ActionResult BiweeklyDate(string date)
        {
            var lastPaid = new Calculate.Biweekly(date);
            return Ok(new { results = lastPaid.NextPayDate() });
        }

        // GET api/calculate/givendate/weeklypaydate/{date}
        [HttpGet]
        [Route("givendate/weeklypaydate/{date}")]
        public ActionResult WeeklyDate(string date)
        {
            var lastPaid = new Calculate.Weekly(date);
            return Ok(new { results = lastPaid.NextPayDate() });
        }

        // GET api/calculate/givendate/biweeklypaythree/{date}
        [HttpGet]
        [Route("givendate/biweeklypaythree/{date}")]
        public ActionResult BiweeklyThreeMonth(string date)
        {
            var lastPaid = new Calculate.Monthly(date);
            return Ok(new { results = "" });
        }
    }
}
