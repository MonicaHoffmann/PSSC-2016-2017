using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University_App.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var statementModel = from s in DefaultConnection.Transactions
                                 select new StatementModel
                                 {
                                     TransactionType = s.TransactionType,
                                     AccountNumber = s.AccountNumber
                                 };
            return View(statementModel);
        }
    }
}