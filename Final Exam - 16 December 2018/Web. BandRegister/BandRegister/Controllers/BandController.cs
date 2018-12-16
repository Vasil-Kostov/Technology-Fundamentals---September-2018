using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandRegisterDbContext())
            {
                var bands = db.Bands.ToList();

                return this.View(bands);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BandRegisterDbContext())
                {
                    db.Bands.Add(band);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                Band band = db.Bands.FirstOrDefault(b => b.Id == id);

                if (band == null)
                {
                    return RedirectToAction("Index");
                }

                return this.View(band);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BandRegisterDbContext())
                {
                    Band bandToEdint = db.Bands.FirstOrDefault(b => b.Id == band.Id);

                    bandToEdint.Name = band.Name;
                    bandToEdint.Members = band.Members;
                    bandToEdint.Honorarium = band.Honorarium;
                    bandToEdint.Genre = band.Genre;

                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                Band band = db.Bands.FirstOrDefault(b => b.Id == id);

                if (band == null)
                {
                    return RedirectToAction("Index");
                }

                return this.View(band);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var db = new BandRegisterDbContext())
            {
                db.Bands.Remove(band);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}