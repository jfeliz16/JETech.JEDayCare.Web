using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using JETech.JEDayCare.Web.Models.Client;
using JETech.NetCoreWeb.Controls.Menu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JETech.NetCoreWeb.Extensions;
using JETech.NetCoreWeb.Exceptions;
using JETech.JEDayCare.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace JETech.JEDayCare.Web.Controllers.Client
{ 
    public class ClientMantController : Controller
    {
        private readonly JEDayCareDbContext _dbContext;

        public ClientMantController(JEDayCareDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        private string GetPathView(string viewName)
        {
            return "Views/Client/ClientMant/" + viewName + ".cshtml";
        }

        // GET: ClientController
        public ActionResult Index()
        {
            return View(GetPathView("Index"));
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create

        [HttpGet]
        public ActionResult Create()
        {
            return View(GetPathView("Create"));
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddClientViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return new JsonResult(new { success = false });
                }              
                return RedirectToAction(GetPathView("Index"));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", JETechException.Parse(ex).AppMessage);
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AddClientViewModel model)
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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

        [HttpGet]
        public object GetActions(DataSourceLoadOptions loadOptions)
        {
            IEnumerable<MenuItem> menuItems = new[]
            {
                new MenuItem{
                    icon = "more",
                    items  = new[] {
                        new MenuItem {
                            text = "Enable//Disable"
                        },
                        new MenuItem {
                            text = "Print",
                            icon = "print"
                        }
                    }
                }
            };

            return DataSourceLoader.Load(menuItems, loadOptions);
        }

        [HttpGet]
        public IEnumerable<Contry> GetContries()
        {
            return _dbContext.Contries.OrderBy(c=> c.Name).AsNoTracking().ToList();
        }
    }
}

