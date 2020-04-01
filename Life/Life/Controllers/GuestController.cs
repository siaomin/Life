using Life.Models.Entity;
using Life.Models.Interface.BLL;
using Microsoft.AspNetCore.Mvc;

namespace Life.Controllers
{
    public class GuestController : Controller
    {
        private IGuest serviceGuest;

        public GuestController(IGuest guestService)
        {
            this.serviceGuest = guestService;
        }

        public IActionResult GuestList()
        {
            var guests = this.serviceGuest.GetGuests();
            return View(guests);
        }

        public IActionResult CreateGuest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuest([FromServices]IGuest guestService, GuestInfo guest)
        {
            guestService.AddGuest(guest);

            return RedirectToAction("GuestList");
        }

        [HttpPost]
        public IActionResult RemoveGuest([FromBody] GuestInfo guest)
        {
            this.serviceGuest.RemoveGuest(guest.Id);

            return Json(Url.Action("GuestList", "Guest"));
        }
    }
}