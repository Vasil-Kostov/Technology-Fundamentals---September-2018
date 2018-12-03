namespace TeisterMask.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using TeisterMask.Data;
    using TeisterMask.Models;

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new TeisterMaskDbContext())
            {
                var allTasks = db.Tasks.ToList();
                return View(allTasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Task taskToCreate)
        {
            if (ModelState.IsValid)
            {
                using (var db = new TeisterMaskDbContext())
                {
                    db.Tasks.Add(taskToCreate);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                if (taskToCreate.Title == null || taskToCreate.Title == string.Empty)
                {
                    TempData["ErrorEmptyTitle"] = "Please enter title";
                }

                return this.View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                Task taskToEdit = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (taskToEdit == null)
                {
                    TempData["ErrorNotExistingTask"] = $"Task with ID:{id} doesn't exist!";
                    return RedirectToAction("Index");
                }

                return this.View(taskToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task editedTask)
        {
            if (ModelState.IsValid)
            {
                using (var db = new TeisterMaskDbContext())
                {
                    var taskToEdit = db.Tasks.First(t => t.Id == editedTask.Id);

                    taskToEdit.Title = editedTask.Title;
                    taskToEdit.Status = editedTask.Status;

                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ErrorEditedEmptyTitle"] = "Pease don't leave the title empty!";

                using (var db = new TeisterMaskDbContext())
                {
                    var taskToEdit = db.Tasks.First(t => t.Id == editedTask.Id);

                    return this.View(taskToEdit);
                }
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (taskToDelete != null)
                {
                    return this.View(taskToDelete);
                }
                else
                {
                    TempData["ErrorNotExistingTask"] = $"Task with ID:{id} doesn't exist!";
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult Delete(Task taskToDelete)
        {
            using (var db = new TeisterMaskDbContext())
            {
                db.Remove(taskToDelete);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}