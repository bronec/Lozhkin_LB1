using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lozhkin_LB1.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult IndexGET()
        {
            Response.ContentType = "text/plain";
            Response.WriteAsync("Using request GET");
            return Ok();
        }

        [HttpPost("/")]
        public ActionResult IndexPOST()
        {
            Response.ContentType = "application/json";
            Response.WriteAsync("Using request POST");

            return Ok();
        }

        [HttpPut("/")]
        public ActionResult IndexPUT()
        {
            Response.ContentType = "text/css";
            Response.WriteAsync("Using request PUT");
            return Ok();
        }
    }
}
