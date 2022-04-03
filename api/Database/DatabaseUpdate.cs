using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;

namespace api.Database
{
    public class DatabaseUpdate : IUpdateRooms
    {
        public void Update(int id, Room sendRoom)
        {
            DatabaseConnection myConnection = new DatabaseConnection();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "";
            if(sendRoom.Status == "true")
            {
                stm = @"UPDATE rooms SET status = 'false' WHERE roomnumber = '" + sendRoom.RoomNumber + "'";
            }
            else
            {
                stm = @"UPDATE rooms SET status = 'true' WHERE roomnumber = '" + sendRoom.RoomNumber + "'";
            }

            using var cmd = new MySqlCommand(stm, con);

            // cmd.Parameters.AddWithValue("@title", mySong.SongTitle);
            // cmd.Parameters.AddWithValue("@timestamp", mySong.SongTimestamp);
            // cmd.Parameters.AddWithValue("@deleted", mySong.Deleted);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}