using Microsoft.AspNetCore.Mvc;

namespace CalendarioFullCalendar.Controllers
{
    public class HomeController : Controller
    {
        // Acción para la página principal del calendario
        public IActionResult Index()
        {
            return View();
        }

        // Acción para la vista del calendario
        public IActionResult Calendar()
        {
            return View();
        }

        // Acción para obtener los eventos del calendario en formato JSON
        [HttpGet]
        public JsonResult GetCalendarEvents()
        {
            var events = new[]
            {
                new {
                    title = "Seminario de actualización en sistemas colaborativos",
                    start = "2024-03-18",
                    end = "2024-07-20"
                }
            };

            return new JsonResult(events);
        }
    }
}
