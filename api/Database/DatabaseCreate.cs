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
            endtime,
            deleted) VALUES(@roomnumber, 
                              @name, 
                              @status, 
                              @size,
                              @starttime,
                              @endtime,
                              @deleted)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@roomnumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@name", room.Name);
            cmd.Parameters.AddWithValue("@status", room.Status);
            cmd.Parameters.AddWithValue("@size", room.Size);
            cmd.Parameters.AddWithValue("@starttime", room.StartTime);
            cmd.Parameters.AddWithValue("@endtime", room.EndTime);
            cmd.Parameters.AddWithValue("@deleted", room.Deleted);

            //cmd.Prepare();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}