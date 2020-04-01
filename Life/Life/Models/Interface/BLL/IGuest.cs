using Life.Models.Entity;
using System.Collections.Generic;

namespace Life.Models.Interface.BLL
{
    public interface IGuest
    {
        List<GuestInfo> GetGuests();

        void AddGuest(GuestInfo guest);

        void RemoveGuest(int guestId);
    }
}