using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInfo.Controllers
{
    public class UserInfoController : Controller
    {
        UserEntityModel db = new UserEntityModel();
        public ActionResult Index()
        {
            return View(db.UserInfoes.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserInfo info)
        {
            if (ModelState.IsValid)
            {
                db.UserInfoes.Add(info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(info);
        }
    }
}