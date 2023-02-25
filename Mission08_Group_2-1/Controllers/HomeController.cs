using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission08_Group_2_1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Group_2_1.Controllers
{
    public class HomeController : Controller
    {
        //Constuctor

        private Context _TaskContext { get; set; }

        public HomeController(Context namedoesntmatter)
        {
            _TaskContext = namedoesntmatter;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QuadrantsView()
        {
            ViewBag.Category = _TaskContext.Categories.ToList();
            var data = _TaskContext.Tasks.ToList();

            return View(data);
        }


        public IActionResult Delete(int taskid)
        {
            var SingleTask = _TaskContext.Tasks.Single(x => x.Id == taskid);
            _TaskContext.Remove(SingleTask);
            _TaskContext.SaveChanges();
            return RedirectToAction("QuadrantsView");
        }

        public IActionResult Checked(int taskid)
        {
            var SingleTask = _TaskContext.Tasks.Single(x => x.Id == taskid);
            SingleTask.Completed = true;
            _TaskContext.Update(SingleTask);
            _TaskContext.SaveChanges();
            return RedirectToAction("QuadrantsView");
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Category = _TaskContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddTask(Models.Task t)
        {
            if (ModelState.IsValid)
            {
                _TaskContext.Add(t);
                _TaskContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Category = _TaskContext.Categories.ToList();

                return View();
            }

        }
    }
}
