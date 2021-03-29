using Microsoft.AspNetCore.Mvc;
using taskManager.Models;

using System.Linq;
using System.Collections.Generic;

namespace taskManager.Controllers
{
    public class Apicontroller : Controller
    {
        private DataContext dbContext;
        public Apicontroller(DataContext db)
        {
            //I'm the constructor
            dbContext = db;
        }
        [HttpGet]
        public IActionResult Test()
        {
            string name = "Marlo";
            return Json(name);
        }
        [HttpGet]
        public IActionResult GetTask()
        {
            //read data base
            // var tasks = dbContext.Tasks.ToList();
            var tasks = dbContext.Tasks.ToList();
            return Json(tasks);
        }
        [HttpPost]
        public IActionResult PostTask([FromBody] Task theTask)
        {
            // send theTask to database
            dbContext.Tasks.Add(theTask);
            dbContext.SaveChanges();
            //return the object 
            return Json(theTask);
        }
    }
}