using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Counter.Controllers
{
    public class CounterController : Controller
    {
        private readonly IApplicationConfiguration _config;

        public CounterController(IApplicationConfiguration config)
        {
            _config = config;
        }

        // GET: Counter
        public ActionResult Index()
        {
            var p = _config.GetApiPath();
            return JavaScript("var counterPath = \"" + p + "\"");
        }
    }
}