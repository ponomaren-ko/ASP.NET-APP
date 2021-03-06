﻿using FreeFlyOnASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeFlyOnASP.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Home/Create
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

        // GET: Admin/Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Home/Edit/5
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

        // GET: Admin/Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Home/Delete/5
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
        
        public ActionResult Cataloge()
        {
            ViewBag.Books = new List<Book>();
            using (BookContext bookContext = new BookContext())
            {
                ViewBag.Books = bookContext.Books.ToList();
            }


            return View();
        }



        public ActionResult Contact()
        {
            ViewBag.Books = new List<Book>();
            using (BookContext bookContext = new BookContext())
            {
                ViewBag.Books = bookContext.Books.ToList();
            }


            return View();
        }


        [HttpPost]
        public string Buy(Order order)
        {
            order.Date = DateTime.Now;
            using (BookContext db = new BookContext())
            {
                // добавляем информацию о покупке в базу данных
                db.Orders.Add(order);
                // сохраняем в бд все изменения
                db.SaveChanges();
            }
            return "Спасибо," + " за покупку!";
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

    }
}
