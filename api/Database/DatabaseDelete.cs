using api.Interfaces;
using MySql.Data.MySqlClient;

namespace api.Database
{
    public class DatabaseDelete : IDeleteRooms
    {
        public void Delete(int id)
        {
            DatabaseConnection myConnection = new DatabaseConnection();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE rooms SET deleted = 'y' WHERE roomnumber = '" + id + "'";

            //string stm = @"DELETE from songs WHERE id = '" + roomnumber + "'";

            using var cmd = new MySqlCommand(stm, con);

            //cmd.Prepare();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}