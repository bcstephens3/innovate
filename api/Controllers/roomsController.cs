using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Database;
using Microsoft.AspNetCore.Cors;

namespace api.Controllers //testing git branch stuff
{
    [Route("api/[controller]")] 
    [ApiController]
    public class roomsController : ControllerBase
    {
        // GET: api/rooms
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Room> Get() //getting all of them
        {
            DatabaseRead reading = new DatabaseRead();
            List<Room> rooms = reading.GetAll();
            return rooms;
        }

        // GET: api/rooms/GetSmall
        [HttpGet("GetSmall")]
        public List<Room> GetSmall()
        {
            string stm = @"SELECT * FROM rooms WHERE size = 'S'";
            DatabaseRead reading = new DatabaseRead();
            List<Room> rooms = reading.Get(stm);
            return rooms;
        }

        // GET: api/rooms/GetMedium
        [HttpGet("GetMedium")]
        public List<Room> GetMedium()
        {
            string stm = @"SELECT * FROM rooms WHERE size = 'M'";
            DatabaseRead reading = new DatabaseRead();
            List<Room> rooms = reading.Get(stm);
            return rooms;
        }

        // GET: api/rooms/GetLarge
        [HttpGet("GetLarge")]
        public List<Room> GetLarge()
        {
            string stm = @"SELECT * FROM rooms WHERE size = 'L'";
            DatabaseRead reading = new DatabaseRead();
            List<Room> rooms = reading.Get(stm);
            return rooms;
        }

        // GET: api/rooms/GetAvlb
        [HttpGet("GetAvlb")]
        public List<Room> GetAvlb()
        {
            string stm = @"SELECT * FROM rooms WHERE status = 'true'";
            DatabaseRead reading = new DatabaseRead();
            List<Room> rooms = reading.Get(stm);
            return rooms;
        }

        // GET: api/rooms/GetFloorG
        [HttpGet("GetFloorG")]
        public List<Room> GetFloorG()
        {
            string stm = @"SELECT * FROM rooms WHERE roomnumber LIKE '0%'";
            DatabaseRead reading = new DatabaseRead();
            List<Room> rooms = reading.Get(stm);
            return rooms;
        }
        // GET: api/rooms/GetFloor1
        [HttpGet("GetFloor1")]
        public List<Room> GetFloor1()
        {
            string stm = @"SELECT * FROM rooms WHERE roomnumber LIKE '1%'";
            DatabaseRead reading = new DatabaseRead();
            List<Room> rooms = reading.Get(stm);
            return rooms;
        }

        // GET: api/rooms/GetFloor2
        [HttpGet("GetFloor2")]
        public List<Room> GetFloor2()
        {
            string stm = @"SELECT * FROM rooms WHERE roomnumber LIKE '2%'";
            DatabaseRead reading = new DatabaseRead();
            List<Room> rooms = reading.Get(stm);
            return rooms;
        }

        // POST: api/rooms
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/rooms/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/rooms/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
