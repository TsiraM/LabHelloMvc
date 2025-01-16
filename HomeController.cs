using Microsoft.AspNetCore.Mvc;
using LabHelloMvc.Models;

namespace LabHelloMvc.Controllers
{
    public class HomeController : Controller
    {
        // Constructor
        public HomeController()
        {
        }

        // Home page - display person details
        public IActionResult Index()
        {
            // Create a person object
            Person person = new Person
            {
                FirstName = "Tsira",
                LastName = "Mamaladze"
            };

            return View(person); // Pass the person object to the view
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
