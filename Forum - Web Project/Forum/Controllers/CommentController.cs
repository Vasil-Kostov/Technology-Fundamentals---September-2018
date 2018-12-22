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
    public class CommentController : Controller
    {
        private readonly ForumDbContext context;

        public CommentController(ForumDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Topic> topics = context.Topics
                                 .Include(t => t.Author)
                                 .Include(t => t.Comments)
                                 .OrderByDescending(t => t.CreateDate)
                                 .ThenByDescending(t => t.LastUpdatedDate)
                                 .ToList();

            return View(topics);
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
                          .SingleOrDefault(t => t.Id == id);

            return View(topic);

        }

        [Authorize]
        [HttpGet]
        [Route("/Topic/Details/{id}/Comment/Create")]
        public IActionResult Create(int id)
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [Route("/Topic/Details/{TopicId}/Comment/Create")]
        public IActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.CreatedDate = DateTime.Now;
                comment.LastUpdatedDate = DateTime.Now;
                comment.AuthorId = context
                                  .Users
                                  .SingleOrDefault(u => u.UserName == User.Identity.Name)
                                  .Id;

                Topic topic = context.Topics.Find(comment.TopicId);
                topic.LastUpdatedDate = DateTime.Now;

                context.Comments.Add(comment);
                context.SaveChanges();

                return Redirect($"/Topic/Details/{comment.TopicId}");
            }

            return View(comment);
        }

        [HttpGet]
        [Route("/Topic/Details/{TopicId}/Comment/Edit/{id}")]
        public IActionResult Edit(int? topicId, int? id)
        {
            if (id == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            Comment comment = context
                              .Comments
                              .Include(c => c.Author)
                              .Include(c => c.Topic)
                              .ThenInclude(t => t.Author)
                              .SingleOrDefault(c => c.CommentId == id);

            if (comment == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            if (!comment.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(comment);
        }

        [Authorize]
        [HttpPost]
        [Route("/Topic/Details/{TopicId}/Comment/Edit/{id}")]
        public IActionResult Edit(Comment comment)
        {
            if (ModelState.IsValid)
            {
                var comentFromDb = context
                                   .Comments
                                   .Include(c => c.Author)
                                   .SingleOrDefault(c => c.CommentId == comment.CommentId);

                if (comentFromDb == null)
                {
                    return RedirectPermanent($"/Topic/Details/{comment.TopicId}");
                }

                comentFromDb.Description = comment.Description;
                comentFromDb.LastUpdatedDate = DateTime.Now;

                Topic topic = context.Topics.Find(comment.TopicId);

                context.SaveChanges();

                return RedirectPermanent($"/Topic/Details/{comment.TopicId}");
            }

            return View(comment);
        }

        [HttpGet]
        [Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        public IActionResult Delete(int? topicId, int? id)
        {
            if (id == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            Comment comment = context
                              .Comments
                              .Include(c => c.Author)
                              .Include(c => c.Topic)
                              .ThenInclude(t => t.Author)
                              .SingleOrDefault(c => c.CommentId == id);

            if (comment == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            if (!comment.IsAuthor(User.Identity.Name) || !comment.Topic.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var comment = context
                          .Comments
                          .Find(id);

            if (comment != null)
            {
                Topic topic = context.Topics.Find(comment.TopicId);
                topic.LastUpdatedDate = DateTime.Now;

                context.Comments.Remove(comment);
                context.SaveChanges();
            }

            return RedirectPermanent($"/Topic/Details/{comment.TopicId}");
        }
    }
}