using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Dao;
using Models.EF;

namespace Cafe_Manager.Areas.Admin.Controllers
{
    public class CUSTOMERController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }[HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CUSTOMER customer)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.Inserts(customer);
                if (id > 0)
                {
                    return RedirectToAction("Index", "CUSTOMER");
                }
            }
            else
            {
                ModelState.AddModelError("","Add succsessfull");
            }
            return View("Index");
        }
    }
}