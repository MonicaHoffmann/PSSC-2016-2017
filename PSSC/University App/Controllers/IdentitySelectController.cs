using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University_App.Models;

namespace University_App.Controllers
{
    public class IdentitySelectController : Controller
    {
        // GET: IdentityType
        public ActionResult Index()
        {
            var identityType = new IdentitySelect { IdentityType = "student" };
            return View(identityType);
        }
    }
}