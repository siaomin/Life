using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Life.ViewModel.Guest
{
    public class CreateGuestViewModel
    {
        public List<SelectListItem> City { get; set; }

        public List<SelectListItem> Town { get; set; }
    }
}