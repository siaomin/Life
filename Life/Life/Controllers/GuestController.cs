using Life.Models.Entity;
using Life.Models.Interface.BLL;
using Life.ViewModel.Common;
using Life.ViewModel.Guest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

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
            var vm = new CreateGuestViewModel();
            var city = new List<CodeTypeInfo>()
            {
                new CodeTypeInfo(){ CodeId="01", CodeName="台北", CodeOrder=1},
                new CodeTypeInfo(){ CodeId="02", CodeName="台中", CodeOrder=2},
                new CodeTypeInfo(){ CodeId="03", CodeName="高雄", CodeOrder=3}
            };

            var cityList = city.Select(x => new SelectListItem()
            {
                Value = x.CodeId,
                Text = x.CodeName
            }).ToList();

            vm.City = cityList;
            return View(vm);
        }

        [HttpPost]
        public IActionResult AddGuest([FromServices]IGuest guestService, GuestInfo guest)
        {
            guestService.AddGuest(guest);

            return RedirectToAction("GuestList");
        }

        public IActionResult ReviceGuest(int guestId)
        {
            var guest = this.serviceGuest.GetGuest(guestId);

            //性別來源資料
            var sex = new List<CodeTypeInfo>()
            {
                new CodeTypeInfo(){ CodeId="M", CodeName="男", CodeOrder=1 },
                new CodeTypeInfo(){ CodeId="F", CodeName="女", CodeOrder=2 }
            };

            var sexList = sex.Select(x => new RadioButtonViewModel()
            {
                Value = x.CodeId,
                Text = x.CodeName,
                Selected = x.CodeId == guest.Sex
            }).ToList();

            //縣市來源資料
            var city = new List<CodeTypeInfo>()
            {
                new CodeTypeInfo(){ CodeId="01", CodeName="台北", CodeOrder=1},
                new CodeTypeInfo(){ CodeId="02", CodeName="台中", CodeOrder=2},
                new CodeTypeInfo(){ CodeId="03", CodeName="高雄", CodeOrder=3}
            };

            var cityList = city.Select(x => new SelectListItem()
            {
                Value = x.CodeId,
                Text = x.CodeName,
                Selected = x.CodeId == guest.City
            }).ToList();

            var response = new ReviceGuestViewModel()
            {
                Guest = guest,
                SexList = sexList,
                CityList = cityList
            };

            return View(response);
        }

        public IActionResult UpdateGuest(GuestInfo guest)
        {
            serviceGuest.UpdateGuest(guest);
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