using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CodeOnDevOpsExample.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}