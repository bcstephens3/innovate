using System;

namespace api.Models
{
    public class Room
    {
        public string RoomNumber { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Size { get; set; }
        public string Capacity {get; set;}
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Deleted { get; set; }
        
    }
}