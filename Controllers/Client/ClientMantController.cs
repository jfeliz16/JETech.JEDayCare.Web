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
using JETech.JEDayCare.Core.Clients.Interfaces;
using JETech.JEDayCare.Web.Helper;

namespace JETech.JEDayCare.Web.Controllers.Client
{ 
    public class ClientMantController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IClientConverterHelper _helper;
        private readonly JEDayCareDbContext _dbContext;

        public ClientMantController(IClientService clientService,
                                    IClientConverterHelper helper,
                                    JEDayCareDbContext dbContext) 
        {
            _clientService = clientService;
            _helper = helper;
            _dbContext = dbContext;
        }

        private string GetPathView(string viewName)
        {
            return "Views/Client/ClientMant/" + viewName + ".cshtml";
        }
        
        [HttpGet]
        public ActionResult Index(string notiMessage)
        {
            ViewBag.NotiMessage = notiMessage;

            return View(GetPathView("Index"));
        }

        public ActionResult Details(int id)
        {
            try
            {
                var data = _clientService.GetClientById(id).Data;
                var model = _helper.ToClientViewModel(data);

                return View(GetPathView("Details"), model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", JETechException.Parse(ex).AppMessage);
                return View();
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(GetPathView("Create"));
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var data = _clientService.GetClientById(id).Data;
                var model = _helper.ToClientViewModel(data);

                return View(GetPathView("Create"), model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", JETechException.Parse(ex).AppMessage);
                return View();
            }
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
    }
}

