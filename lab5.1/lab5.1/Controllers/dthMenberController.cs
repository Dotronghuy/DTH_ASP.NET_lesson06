using lab5._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab5._1.Controllers
{
    public class dthMenberController : Controller
    {
        // GET: dthMenber
        public ActionResult DthCreateOne()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DthCreateOne(dthMenber m)
        {
            return View("Details", m);
        }
        public ActionResult DthCreateTwo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DthCreateTwo(dthMenber m)
        {
            if (m.ID == null)
            {
                ViewBag.error = "Hãy nhập ID";
                return View();
            }
            if (m.Username == null)
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if (m.Fullname == null)
            {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
            }
            if (m.Age == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
            }
            if (m.Email == null)
            {
                ViewBag.error = "Hãy nhập email";
                return View();
            }
            string regexPattern = @"[A-Za-z0-0._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if (!System.Text.RegularExpressions.Regex.IsMatch(m.Email, regexPattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng";
                return View();
            }
            return View("Details", m);
        }
        [HttpPost]
        public ActionResult DthCreateThree(dthMenber m)
        {
            if (ModelState.IsValid)
            {
                return View("Details", m);
            }
            else
                return View();

        }
        public ActionResult Details()
        {
            return View();
        }

    }
}