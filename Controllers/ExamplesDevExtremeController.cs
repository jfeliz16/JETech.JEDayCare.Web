using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JETech.JEDayCare.Web.Controllers
{
    public class ExamplesDevExtremeController : Controller
    {
        // GET: ExamplesDevExtreme
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExamplesDevExtreme/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamplesDevExtreme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamplesDevExtreme/Create
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

        // GET: ExamplesDevExtreme/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamplesDevExtreme/Edit/5
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

        // GET: ExamplesDevExtreme/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamplesDevExtreme/Delete/5
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
        public object GetProducts(DataSourceLoadOptions loadOptions)
        {            
            return DataSourceLoader.Load(MenuData.Products, loadOptions);
        }
    }
}

public static class MenuData
{
    public static readonly IEnumerable<MenuItem2> Products = new[] {
            new MenuItem2 {
                text = "Video Players",
                items = new[] {
                    new MenuItem2 {
                        text = "HD Video Player",
                        price = 220,
                        icon = "../../images/ProductsLarge/1.png"
                    },
                    new MenuItem2 {
                        text = "SuperHD Video Player",
                        price = 270,
                        icon = "../../images/ProductsLarge/2.png"
                    }
                }
            }
        };

   
}

public class MenuItem2
{
    public string text { get; set; }
    public bool disabled { get; set; }
    public string icon { get; set; }
    public int price { get; set; }
    public IEnumerable<MenuItem2> items { get; set; }
}