using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Dao;
using Models.EF;

namespace Cafe_Manager.Areas.Admin.Controllers
{
    public class AdminHomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Customer()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddResource()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddResource(PRODUCT product)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.Insertss(product);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            else
            {
                ModelState.AddModelError("", "Add succsessfull");
            }
            return View("Index");
        }
        public ActionResult EditResource()
        {
            return View();
        }
    }
}