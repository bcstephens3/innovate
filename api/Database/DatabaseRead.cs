using System.Collections.Generic;
using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;


namespace api.Database
{
    public class DatabaseRead : IReadRooms
    {
        public List<Room> GetAll()
        {
            DatabaseConnection myConnection = new DatabaseConnection();
            string cs = myConnection.cs;
            List<Room> allRooms = new List<Room>();

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM rooms";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Room temp = new Room() //ternary operator --> ? what it returns : what if false //use almost like a try-catch
                {
                    RoomNumber = rdr.IsDBNull(0) ? null : rdr.GetString(0),
                    Name = rdr.IsDBNull(1) ? null : rdr.GetString(1),
                    Status = rdr.IsDBNull(2) ? null : rdr.GetString(2),
                    Size = rdr.IsDBNull(3) ? null : rdr.GetString(3),
                    StartTime = rdr.IsDBNull(4) ? null : rdr.GetString(4),
                    EndTime = rdr.IsDBNull(5) ? null : rdr.GetString(5),
                    Deleted = rdr.IsDBNull(6) ? null : rdr.GetString(6)
                };
                if(temp.Size == "S"){
                    temp.Capacity = "2-4 students";
                } 
                if(temp.Size == "M"){
                    temp.Capacity = "4-6 students";
                } 
                if(temp.Size == "L"){
                    temp.Capacity = "6-8 students";
                } 
                int tempInt = int.Parse(temp.RoomNumber);
                if(tempInt >= 2000 && tempInt < 3000)
                {
                    temp.FloorNumber = "Floor 2";
                }
                if(tempInt >= 1000 && tempInt < 2000)
                {
                    temp.FloorNumber = "Floor 1";
                }
                if(tempInt >= 0 && tempInt < 1000)
                {
                    temp.FloorNumber = "Floor G";
                }
                allRooms.Add(temp);
            }
            return allRooms; 
        }
        public Room GetOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Room> Get(string stm)
        {
            DatabaseConnection myConnection = new DatabaseConnection();
            string cs = myConnection.cs;
            List<Room> allRooms = new List<Room>();

            using var con = new MySqlConnection(cs);
            con.Open();

            // string stm = "SELECT * FROM rooms";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Room temp = new Room() //ternary operator --> ? what it returns : what if false //use almost like a try-catch
                {
                    RoomNumber = rdr.IsDBNull(0) ? null : rdr.GetString(0),
                    Name = rdr.IsDBNull(1) ? null : rdr.GetString(1),
                    Status = rdr.IsDBNull(2) ? null : rdr.GetString(2),
                    Size = rdr.IsDBNull(3) ? null : rdr.GetString(3),
                    StartTime = rdr.IsDBNull(4) ? null : rdr.GetString(4),
                    EndTime = rdr.IsDBNull(5) ? null : rdr.GetString(5),
                    Deleted = rdr.IsDBNull(6) ? null : rdr.GetString(6)
                };
                allRooms.Add(temp);
            }
            return allRooms; 
        }
    }
}