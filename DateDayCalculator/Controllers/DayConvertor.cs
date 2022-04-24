using Microsoft.AspNetCore.Mvc;
using DateDayCalculator.Models;
using System.Net;
using System.Globalization;

namespace DateDayCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DayConvertor: ControllerBase
    {
        [HttpPost]
        [Route("Day")]
        public async Task<IActionResult> PostDay([FromBody] string date)
        {
            DateTime birthday = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int year = birthday.Year;
            int month = birthday.Month;
            int day = birthday.Day;
            DateTime dt = new DateTime(year, month, day);
            string dayofweek = dt.ToString("dddd");
            //var number = "";
            return Ok(new{ message = dayofweek });
      


        }
    }
}
