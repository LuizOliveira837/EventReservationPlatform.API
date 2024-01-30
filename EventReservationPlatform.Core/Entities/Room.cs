using EventReservationPlatform.Core.Enums;
using Mapster;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventReservationPlatform.Core.Entities
{
    public class Room
    {
        public Room(string name, int capacity, Guid locationId)
        {
            Id = Guid.NewGuid();
            RoomName = name;
            Capacity = capacity;
            LocationId = locationId;
            Status = StatusEntity.Enable;

        }

        public Room()
        {
            Id = Guid.NewGuid();
        }

        public readonly Guid Id;
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        //public virtual Location Location { get; set; }
        public Guid LocationId { get; set; }
        public StatusEntity Status { get; set; }


        public void ToggleStatus()
        {
            if(Status == StatusEntity.Enable) Status = StatusEntity.Disable;

            else Status = StatusEntity.Enable;
        }




    }
}
