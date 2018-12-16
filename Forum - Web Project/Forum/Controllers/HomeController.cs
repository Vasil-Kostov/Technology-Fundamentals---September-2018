using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forum.Models;
using Forum.Data;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ForumDbContext context;
    
        public HomeController(ForumDbContext context)
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
    }
}
