using Life.Models.Entity;
using Life.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Life.ViewModel.Guest
{
    public class ReviceGuestViewModel
    {
        public GuestInfo Guest { get; set; }

        public List<RadioButtonViewModel> SexList { get; set; }

        public List<SelectListItem> CityList { get; set; }
    }
}