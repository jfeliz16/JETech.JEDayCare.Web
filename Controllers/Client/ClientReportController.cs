using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JETech.NetCoreWeb.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JETech.JEDayCare.Web.Controllers.Client
{
    public class ClientReportController : Controller
    {
        private string GetPathView(string viewName)
        {
            return "Views/Client/ClientReport/" + viewName + ".cshtml";
        }

        // GET: ClientReportController        
        public ActionResult Index()
        {
            return PartialView(GetPathView("Index"));
        }

        // GET: ClientReportController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientReportController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientReportController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientReportController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientReportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientReportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
