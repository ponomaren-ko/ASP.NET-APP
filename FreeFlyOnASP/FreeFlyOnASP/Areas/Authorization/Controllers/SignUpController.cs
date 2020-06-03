using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeFlyOnASP.Areas.Authorization.Controllers
{
    /// <summary>
    /// Контроллер для регистрации аккаунта 
    /// </summary>
    public class SignUpController : Controller
    {
        // GET: Authorization/SignUp
        public ActionResult Index()
        {
            @ViewBag.Title = "Страница регистрации";
            return View();
        }

        // GET: Authorization/SignUp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Authorization/SignUp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authorization/SignUp/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Authorization/SignUp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Authorization/SignUp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Authorization/SignUp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authorization/SignUp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
