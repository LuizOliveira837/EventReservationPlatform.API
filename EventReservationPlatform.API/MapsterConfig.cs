using EventReservationPlatform.Core.Dtos.Room;
using EventReservationPlatform.Core.Dtos.RoomDtos;
using EventReservationPlatform.Core.Entities;
using Mapster;

namespace EventReservationPlatform.API
{
    public static  class MapsterConfig
    {
        public static void RegisterMapsterConfiguration(this IServiceCollection services)
        {
            TypeAdapterConfig<RequestUpdateRoomDto, Room>
                .NewConfig()
                .Ignore(dest => dest.Id)
                .TwoWays();

            TypeAdapterConfig<Room, ResponseViewRoomDto>
                .NewConfig()
                .Map(dest => dest.Status, src => src.Status.ToString());



        }
    }
}
