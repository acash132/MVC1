using MVCFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult IndexStud()
        {
            return View();
        }
        public ActionResult StudentDetails()
        {
            StudentModel student = new StudentModel();
            {
                student.Id = 1;
                student.Name = "Akash";
                student.Address = "Vanasthalipuram";
            }
            return View(student);
        }
    }
}