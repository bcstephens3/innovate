using api.Models;

namespace api.Interfaces
{
    public interface IUpdateRooms
    {
         public void Update(int id, Room sendRoom);
    }
}