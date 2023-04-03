using JoycePieShop.Models;
using JoycePieShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JoycePieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        
        public PieController(IPieRepository pieRepository)
        {
            //we have told the service in program.cs that when IpieRepo is needed it shold use MockPieRepo tru Constructor injection
           //_pieRepository = new MockPieRepository(); insted of making it's instance
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            //ViewBag.Title = "Pie Overview";

            var pies = _pieRepository.GetAllPies().OrderBy(p=>p.Name);
            
          
            var pieVM = new PieVM()
            {
                Title = "Welcome to Joyce pie shop",
                Pies = pies.ToList()
            };
            return View(pieVM);
        }
        public IActionResult Details(int id)
        {
            var detail = _pieRepository.GetPieById(id);
            if(detail == null)
            {
                return NotFound();
            }
            return View(detail);
        }
    }
}
