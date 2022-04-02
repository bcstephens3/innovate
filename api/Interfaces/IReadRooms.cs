using System.Collections.Generic;
using api.Models;

namespace api.Interfaces
{
    public interface IReadRooms
    {
         public List<Room> GetAll();
         public Room GetOne(int id);
    }
}