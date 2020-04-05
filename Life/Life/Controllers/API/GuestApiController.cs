using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Life.Models.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Life.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GuestApiController : ControllerBase
    {
        // POST api/<controller>
        [HttpPost]
        public string Create(GuestInfo guest)
        {
            return guest.Id.ToString();
        }

        [HttpPost]
        public int Create2(int number)
        {
            return number;
        }
    }
}
