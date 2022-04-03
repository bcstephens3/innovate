using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers //testing git branch stuff
{
    [Route("api/[controller]")]
    [ApiController]
    public class roomsController : ControllerBase
    {
        // GET: api/rooms
        [HttpGet]
        public List<string> Get() //getting all of them
        {
            return new List<string> {"test1", "test2", "testing everything", "this is all of them"};
        }

        // GET: api/rooms/GetSmall
        [HttpGet("GetSmall")]
        public string GetSmall()
        {
            return "only one small room";
        }

        // GET: api/rooms/GetMedium
        [HttpGet("GetMedium")]
        public List<string> GetMedium()
        {
            return new List<string> {"medium1", "meidum2", "lots of mediums"};;
        }

        // GET: api/rooms/GetLarge
        [HttpGet("GetLarge")]
        public List<string> GetLarge()
        {
            return new List<string> {"llarge", "lllager", "laerges"};;
        }

        // GET: api/rooms/GetAvlb
        [HttpGet("GetAvlb")]
        public List<string> GetAvlb()
        {
            return new List<string> {"avlb", "this is avlb", "this is available"};;
        }

        // GET: api/rooms/GetFloorG
        [HttpGet("GetFloorG")]
        public List<string> GetFloorG()
        {
            return new List<string> {"g", "this is g", "this is GGGGGGGGG"};;
        }
        // GET: api/rooms/GetFloor1
        [HttpGet("GetFloor1")]
        public List<string> GetFloor1()
        {
            return new List<string> {"1", "this is 1floor", "this is 111111"};;
        }

        // GET: api/rooms/GetFloor2
        [HttpGet("GetFloor2")]
        public List<string> GetFloor2()
        {
            return new List<string> {"2", "this is 2", "this is 2"};;
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
