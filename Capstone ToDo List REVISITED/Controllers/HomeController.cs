using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Capstone_ToDo_List_REVISITED.Models;
using System.Transactions;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Capstone_ToDo_List_REVISITED.Controllers
{
    public class HomeController : Controller
    {
        private readonly CapStoneContext _capstone;
      

        public HomeController(CapStoneContext capstone)
        {
            _capstone = capstone;
        }

        //CRUD FUNCTIONS

        //READ ALL the elements of the Devs table
        public IActionResult Index()
        {
            var model = _capstone.Devs.ToList();

            return View(model);
        }

        [HttpGet] //This method is simply displaying info in the view
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTask(Devs newTask)
        {
            if (ModelState.IsValid)
            {
                string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;

                var taskIndex = _capstone.Devs.Where(x => x.UserId == id).ToList();
                newTask.UserId = id;

                _capstone.Devs.Add(newTask);
                await _capstone.SaveChangesAsync();
            }
            return RedirectToAction("ViewTasksToDo");
        }

        public IActionResult DeleteTask(int id)
        {
            //find the task we want to delete from the database
            //the Find() will bring back an entire Task via its primary key

            var foundTask = _capstone.Devs.Find(id);
            if(foundTask != null)
            {
                //removes task from the database
                _capstone.Devs.Remove(foundTask);
                 _capstone.SaveChanges();
            }
            return RedirectToAction("ViewTasksToDo");
        }

        //public IActionResult SeeTasksByUser(int id)
        //{
        //    List<Task> tasks = _capstone.Devs.Where(x => x.UserId == id).ToList();
        //    Task tasks = 
        //}

        public IActionResult UpdateTask(int id)
        {
            //find the whold task we're looking to update
            Devs updatedTask = _capstone.Devs.Find(id);
            if(updatedTask == null)
            {
                return RedirectToAction("ViewTasksToDo");
            }
            else
            {
                return View(updatedTask);
            }
        }

        public IActionResult SaveChanges(Devs updatedTask)
        {
            Devs capstone = _capstone.Devs.Find(updatedTask.Id);

            //merging the capstone database on SQL  with the updatedTasks one property ata a time
            //This is to to prevent losing information in the capstone that might not
            //but in the updatedTasks

            capstone.ItemDescription = updatedTask.ItemDescription;
            capstone.DueDate = updatedTask.DueDate;
            capstone.Complete = updatedTask.Complete;
            capstone.TaskName = updatedTask.TaskName;
            

            //creates a log og changes for this entry. A way to track our work
            _capstone.Entry(capstone).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _capstone.Update(capstone);
            _capstone.SaveChanges();

            return RedirectToAction("ViewTasksToDo");
        }

        [Authorize]
        public IActionResult ViewTasksToDo()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var taskIndex = _capstone.Devs.Where(x => x.UserId == id).ToList();

            return View(taskIndex);
        }

        public IActionResult TaskIndex()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
