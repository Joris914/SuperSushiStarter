using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperSushi.Data;

namespace SusperSushi.Web.Controllers
{
    public class MenusController : Controller
    {
        IMenuRepository repo = new MenuRepositorySql();

        public IActionResult Index()
        {
            var model = repo.GetAll();

            return View(model);
        }

        public IActionResult Create()
        {
            return View(new Menu());
        }

        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            var model = repo.Create(menu);
            return View("Details",model);
        }

        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var model = repo.GetOne(id.Value);
                return View(model);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(int id, Menu menu)
        {
            if (id != menu.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var result = repo.Update(menu);
                return RedirectToAction("Index");
            }
            return View(menu);
        }

        public IActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var gerecht = repo.GetOne(id.Value);
            if (gerecht == null)
            {
                return NotFound();
            }

            return View(gerecht);
        }

        public IActionResult Delete(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return View();
        }

    }
}
