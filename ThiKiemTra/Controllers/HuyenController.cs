using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThiKiemTra.Data;
using ThiKiemTra.Models;

namespace ThiKiemTra.Controllers
{
    public class HuyenController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HuyenController(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Huyen> huyen = _db.huyens;
            return View(huyen);
        }
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var b = _db.huyens.Find(id);
            if (b == null) return NotFound();

            return View(b);
        }
        public IActionResult Create()
        {
            return View();
        }
        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Huyen obj)
        {
            if (ModelState.IsValid)
            {
                _db.huyens.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(obj);

        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var b = _db.huyens.Find(id);
            if (b == null) return NotFound();

            return View(b);
        }
        [HttpPost]
        public IActionResult Edit(Huyen obj)
        {
            if (ModelState.IsValid)
            {
                _db.huyens.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var b = _db.huyens.Find(id);
            if (b == null) return NotFound();

            return View(b);
        }

        [HttpPost]
        public IActionResult DeleteD(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var b = _db.huyens.Find(id);
            if (b == null) return NotFound();

            _db.huyens.Remove(b);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
