using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace Sky.Controllers
{
    public class AppController : Controller
    {
        [Produces("text/html")]
        public IActionResult Index()
        {
            return View("~/wwwroot/build/index.html");
        }
    }
}
