using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
namespace TaskManager.Controllers
{
    public class TasksController : Controller
    {
        //add our database instance
        private readonly ApplicationDbContext _context;
        //constructor
        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //variable to put tasks from db into a list. 
            var tasks = _context.Tasks.ToList(); 

            return View(tasks);
        }
    }
}
