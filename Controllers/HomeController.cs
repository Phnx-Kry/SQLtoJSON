using SQLtoJSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQLtoJSON.Controllers
{
    public class HomeController : Controller
    {
        private static readonly angularEntities angularEntities = new angularEntities();
        angularEntities db = angularEntities;
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllEmployee()
        {


            List<tble_employee> empList = db.tble_employee.ToList();
            List<EmployeeViewModel> li = empList.Select(x => new EmployeeViewModel
            {
                emp_id = x.emp_id,
                emp_name = x.emp_name,
                emp_sal = x.emp_sal,
                emp_dept_fk = x.emp_dept_fk,
                /*dep_id = x.depart.dep_id,*/
                dep_name = x.depart.dep_name

            }).ToList();

            return Json(li, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        


    }
}