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
    public class TopicController : Controller
    {
        private readonly ForumDbContext context;

        public TopicController(ForumDbContext context)
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
        public IActionResult Create(Topic topic)
        {
            if (ModelState.IsValid)
            {
                topic.CreateDate = DateTime.Now;
                topic.LastUpdatedDate = DateTime.Now;
                topic.AuthorId = context.Users
                                 .Where(u => u.UserName == User.Identity.Name)
                                 .First()
                                 .Id;

                context.Topics.Add(topic);
                context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = context.Topics
                          .Include(t => t.Author)
                          .Include(t => t.Comments)
                          .ThenInclude(c => c.Author)
                          .Where(t => t.Id == id)
                          .SingleOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = context.Topics
                          .Include(t => t.Author)
                          .SingleOrDefault(t => t.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Topic topic = context.Topics
                           .Include(t => t.Author)
                           .SingleOrDefault(t => t.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            context.Topics.Remove(topic);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = context.Topics
                .Include(t => t.Author)
                .SingleOrDefault(t => t.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(Topic topic)
        {
            if (ModelState.IsValid)
            {
                Topic topicToEdit = context.Topics
                                    .Include(t => t.Author)
                                    .SingleOrDefault(t => t.Id == topic.Id);

                if (topicToEdit == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                topicToEdit.Title = topic.Title;
                topicToEdit.Description = topic.Description;
                topicToEdit.LastUpdatedDate = DateTime.Now;

                context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}