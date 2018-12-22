using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogIN_Project.Controllers
{
    public class LogInAndLogUpWithAnotherThirdController : Controller
    {
        // GET: GoogleLogIN
        public ActionResult GoogleLogIN()
        {
            return View();
        }
        public ActionResult FacebookLogIN()
        {

            return View();
        }
    }
}
