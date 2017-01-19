using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University_App.Models;
using System.Data;
using System.Data.SqlClient;

namespace University_App.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            var student = new Student { RegistrationNumber = "86473", Name = "Popescu Andreea", AccumulatedCredits = 60 };
            
            DataTable dt = new DataTable();
            using (var con = new SqlConnection("Data Source=local;Initial Catalog=Test;Integrated Security=True"))
            {
                using (var command = new SqlCommand("SELECT * from Students"))
                {
                    con.Open();
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        dt.Load(dr);
                    }
                }
            }       

            return View(dt);
        }
    }
}