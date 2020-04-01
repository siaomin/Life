using Life.Models;
using Life.ViewModel.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Life.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var viewModel = new ContactPersonViewModel()
            {
                Name = "William Cheng",
                CellPhoneNumber = "0923-9XX-X1X",
                Address = "高雄市三民區七賢十路577號105樓"
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
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