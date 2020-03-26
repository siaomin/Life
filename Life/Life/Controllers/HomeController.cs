using Life.Models;
using Life.Models.Entity;
using Life.ViewModel.Home;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Life.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GuestList()
        {
            var guests = new List<GuestInfo>()
            {
                new GuestInfo() { Name="阿統伯", Quantity=5, TableNumber=1, Remark=""},
                new GuestInfo() { Name="阿水嬸", Quantity=4, TableNumber=2, Remark=""},
                new GuestInfo() { Name="三姑媽", Quantity=6, TableNumber=3, Remark=""},
                new GuestInfo() { Name="四嬸婆", Quantity=2, TableNumber=1, Remark=""},
                new GuestInfo() { Name="團長", Quantity=2, TableNumber=1, Remark=""},
                new GuestInfo() { Name="班", Quantity=2, TableNumber=3, Remark=""},
                new GuestInfo() { Name="黛安娜", Quantity=2, TableNumber=2, Remark=""},
                new GuestInfo() { Name="瑪琳", Quantity=2, TableNumber=3, Remark=""}
            };

            return View(guests.OrderBy(x => x.TableNumber).ToList());
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