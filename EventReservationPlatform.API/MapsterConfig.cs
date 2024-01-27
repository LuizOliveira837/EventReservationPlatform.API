using EventReservationPlatform.Core.Dtos;
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

           
        }
    }
}
