using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;

namespace api.Database
{
    public class DatabaseCreate : ICreateRooms
    {
        public void Create(Room room)
        {
            DatabaseConnection myConnection = new DatabaseConnection();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO rooms
            (roomnumber,
            name,
            status,
            size,
            starttime,
            endtime) VALUES(@room_number, 
                              @name, 
                              @status, 
                              @Favorited)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@roomnumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@name", room.Name);
            cmd.Parameters.AddWithValue("@status", room.Status);
            cmd.Parameters.AddWithValue("@size", room.Size);
            cmd.Parameters.AddWithValue("@starttime", room.Size);
            cmd.Parameters.AddWithValue("@endtime", room.Size);

            //cmd.Prepare();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}