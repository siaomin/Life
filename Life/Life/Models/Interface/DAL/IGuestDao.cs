using Life.Models.Entity;
using System.Collections.Generic;

namespace Life.Models.Interface.DAL
{
    public interface IGuestDao
    {
        List<GuestInfo> GetGuests();

        void AddGuest(GuestInfo guest);

        void RemoveGuest(int guestId);
    }
}