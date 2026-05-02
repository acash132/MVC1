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


        public ActionResult Details()
        {
            StudentModel1 student = new StudentModel1()
            { 
                StudentId = 1,
                StudentName = "Akash",
                Age = 25,
                Email = "akash@example.com",
                EnrollmentDate = DateTime.Now
            };
            return View(student);
        }

        public ActionResult ListStudent()
        { 
            List<StudentModel1> students = new List<StudentModel1>
            {
                new StudentModel1 { StudentId = 1, StudentName = "Akash", Age = 25, Email = "akash@example.com", EnrollmentDate = DateTime.Now },
                new StudentModel1 { StudentId = 2, StudentName = "John", Age = 22, Email = "john@example.com", EnrollmentDate = DateTime.Now },
                new StudentModel1 { StudentId = 3, StudentName = "Jane", Age = 24, Email = "jane@example.com", EnrollmentDate = DateTime.Now }
            };
            return View(students);
        }

        public ActionResult ListEmployee()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>
            {
                new EmployeeModel { EmployeeId = 1, EmployeeName = "Akash", Age = 25, Email = "akash@example.com", DOB = DateTime.Now },
                new EmployeeModel { EmployeeId = 2, EmployeeName = "John", Age = 22, Email = "john@example.com", DOB = DateTime.Now },
                new EmployeeModel { EmployeeId = 3, EmployeeName = "Jane", Age = 24, Email = "jane@example.com", DOB = DateTime.Now }
            };
            return View(employees);
        }


    }
}
