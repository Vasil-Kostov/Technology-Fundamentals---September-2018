namespace ToDoList.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using ToDoList.Data;
    using ToDoList.Models;

    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new ToDoDBContext())
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
                using (var db = new ToDoDBContext())
                {
                    db.Tasks.Add(taskToCreate);
                    db.SaveChanges();
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Fill up all the fields of the form!";
                return this.View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new ToDoDBContext())
            {
                var taskToEdit = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (taskToEdit == null)
                {
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
                using (var db = new ToDoDBContext())
                {
                    var taskToEdit = db.Tasks.First(t => t.Id == editedTask.Id);

                    taskToEdit.Title = editedTask.Title;
                    taskToEdit.Comments = editedTask.Comments;

                    db.SaveChanges();

                    return RedirectToAction("Index");
                }               
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using (var db = new ToDoDBContext())
            {
                Task taskDetails = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (taskDetails == null)
                {
                    return RedirectToAction("Index");
                }

                return View(taskDetails);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            using (var db = new ToDoDBContext())
            {
                var taskToDelete = db.Tasks.First(t => t.Id == id);

                db.Tasks.Remove(taskToDelete);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}