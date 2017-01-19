using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PSSC.ViewModels;
using Models.Professor;
using Models.Commands;

namespace MVC_PSSC.Controllers
{
    public class AccountController : Controller
    {
        private DBEntities storeDB = new DBEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            if(avm.account.Username.Equals("profesor") && avm.account.Password.Equals("parola"))
            {
                Session["username"] = avm.account.Username;
                return View("Welcome");
            }
            else
            {
                ViewBag.Error = "Account is not valid";
                return View("Index");
            }
        }

        public ActionResult Logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index");
        }


        public ActionResult DisplayDatabase()
        {
            var entities = new DBEntities();

            return View(entities.MyDatabase.ToList());
        }

        public ActionResult AddExamGrade()
        {
            MyDatabase.ExamGrade.Add(SetGradesExamAndRetake);
            MyDatabase.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddActivityGradeProportion()
        {
            MyDatabase.ActivityGradeProportion.Add(SetActivityGradeProportion);
            MyDatabase.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddAttendance()
        {
            MyDatabase.Attendance.Add(SetAttendance);
            MyDatabase.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
