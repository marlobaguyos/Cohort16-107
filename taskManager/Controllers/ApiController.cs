using Microsoft.AspNetCore.Mvc;
using taskManager.Models;

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
            string name = "Sergio";
            return Json(name);
        }
        [HttpGet]
        public IActionResult GetTask()
        {
            return Json(null);
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