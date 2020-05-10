using Models.Dao;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cafe_Manager.Areas.Admin.Controllers
{
    public class CatelogyController : Controller
    {
        // GET: Admin/Catelogy
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CATEGORY catelogy)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.Insertsss(catelogy);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Catelogy");
                }
            }
            else
            {
                ModelState.AddModelError("", "Add succsessfull");
            }
            return View("Index");
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}