using Life.Models.Entity;
using System.Collections.Generic;

namespace Life.Models.Interface.BLL
{
    public interface IGuest
    {
        List<GuestInfo> GetGuests();

        GuestInfo GetGuest(int guestId);

        void UpdateGuest(GuestInfo guest);

        void AddGuest(GuestInfo guest);

        void RemoveGuest(int guestId);
    }
}