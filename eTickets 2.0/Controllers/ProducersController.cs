using eTickets_2._0.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets_2._0.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Producers.ToList();
            return View(data);
        }
    }
}
