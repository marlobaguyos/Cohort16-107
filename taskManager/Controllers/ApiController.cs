using Microsoft.AspNetCore.Mvc;
using taskManager.Models;

namespace taskManager.Controllers
{
    public class Apicontroller : Controller
    {
        public Apicontroller()
        {
            //I'm the constructor
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

            // assign an id to the
            theTask.Id = 1;
            //return the object 
            return Json(theTask);
        }
    }
}