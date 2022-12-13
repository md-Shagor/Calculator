using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcuController : Controller
    {
        // GET: Calu
        public ActionResult Index()
        {
            return View(new Calcu());
        }

        [HttpPost]

        public ActionResult Index(Calcu c, string Calculate)
        {
            if (Calculate == "add")
            {
                c.Op = c.Num1 + c.Num2;
            }
            else if (Calculate == "min")
            {
                c.Op = c.Num1 - c.Num2;
            }
            else if (Calculate == "sub")
            {
                c.Op = c.Num1 * c.Num2;
            }
            else
            {
                c.Op = c.Num1 / c.Num2;
            }
            return View(c);
        }
        public ActionResult Mycal()
        { 
            return View();
        }

    }
}