using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ForumDbContext context;

        public CategoryController(ForumDbContext context)
        {
            this.context = context;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Category category)
        {
            category.AuthorId = context.Users
                              .Where(u => u.UserName == this.User.Identity.Name)
                              .First()
                              .Id;

            if (ModelState.IsValid)
            {
                context.Categoties.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(category);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Category category = context.Categoties
                                .Include(c => c.Author)
                                .Include(ct => ct.Topics)
                                .ThenInclude(t => t.Author)
                                .SingleOrDefault(c => c.Id == id);

            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Category> categories = context
                                        .Categoties
                                        .Include(c => c.Topics)
                                        .ToList();

            ViewData["Categories"] = categories;

            return View(category);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Category category = context.Categoties
                                .SingleOrDefault(c => c.Id == id);

            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!category.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(category);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                Category catgoryFromDb = context.Categoties
                                         .SingleOrDefault(c => c.Id == category.Id);

                if (catgoryFromDb == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                catgoryFromDb.Name = category.Name;
                context.SaveChanges();
            }

            return View(category);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Category category = context.Categoties
                                .SingleOrDefault(c => c.Id == id);

            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!category.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(category);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Category category = context.Categoties.SingleOrDefault(c => c.Id == id);

            if (category != null)
            {
                context.Categoties.Remove(category);
                context.SaveChanges();
            }

            return RedirectPermanent("/");
        }
    }
}