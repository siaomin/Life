using Life.Models.Entity;
using System.Collections.Generic;

namespace Life.Models.Interface.DAL
{
    public interface IGuestDao
    {
        List<GuestInfo> GetGuests();

        GuestInfo GetGuest(int guestId);

        void AddGuest(GuestInfo guest);

        void UpdateGuest(GuestInfo guest);

        void RemoveGuest(int guestId);
    }
}