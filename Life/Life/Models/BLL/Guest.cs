using Life.Models.Entity;
using Life.Models.Interface.BLL;
using Life.Models.Interface.DAL;
using System.Collections.Generic;

namespace Life.Models.BLL
{
    public class Guest : IGuest
    {
        private IGuestDao dao;

        public Guest(IGuestDao guestDao)
        {
            this.dao = guestDao;
        }

        public GuestInfo GetGuest(int guestId)
        {
            return dao.GetGuest(guestId);
        }

        public List<GuestInfo> GetGuests()
        {
            return dao.GetGuests();
        }

        public void AddGuest(GuestInfo guest)
        {
            dao.AddGuest(guest);
        }

        public void UpdateGuest(GuestInfo guest)
        {
            dao.UpdateGuest(guest);
        }

        public void RemoveGuest(int guestId)
        {
            dao.RemoveGuest(guestId);
        }
    }
}