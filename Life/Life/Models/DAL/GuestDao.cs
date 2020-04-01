using Dapper;
using Life.Models.Entity;
using Life.Models.Interface.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Life.Models.DAL
{
    public class GuestDao : IGuestDao
    {
        private string connect;

        public GuestDao(IConfiguration config)
        {
            this.connect = config.GetConnectionString("local");
        }

        public List<GuestInfo> GetGuests()
        {
            using (var conn = new SqlConnection(connect))
            {
                var sql = @"SELECT * FROM Guest";

                return conn.Query<GuestInfo>(sql).ToList();
            }
        }

        public void AddGuest(GuestInfo guest)
        {
            using (var conn = new SqlConnection(connect))
            {
                var sql = @"INSERT INTO Guest(Name, Sex, Address, Telephone, Cellphone)
                                       VALUES(@name, @sex, @address, @telephone, @cellphone)";

                var parameter = new DynamicParameters();
                parameter.Add("name", guest.Name);
                parameter.Add("sex", guest.Sex);
                parameter.Add("address", guest.Address);
                parameter.Add("telephone", guest.Telephone);
                parameter.Add("cellphone", guest.Cellphone);

                conn.Execute(sql, parameter);
            }
        }

        public void RemoveGuest(int guestId)
        {
            using (var conn = new SqlConnection(connect))
            {
                var sql = @"DELETE FROM Guest
                            WHERE Id = @guestId";

                var parameter = new DynamicParameters();
                parameter.Add("guestId", guestId);

                conn.Execute(sql, parameter);
            }
        }
    }
}