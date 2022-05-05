using AutoMapper;
using HospitalClassLibrary.GraphicalEditor.Models;
using HospitalClassLibrary.RoomEquipment.Models;
using HospitalClassLibrary.Schedule.Models;

namespace HospitalAPI.DTOs.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EquipmentDto, Equipment>();
            CreateMap<FloorEquipmentDto, Equipment>();
            CreateMap<FloorRoomDto, Room>();
            CreateMap<RoomWithEquipmentDto, Room>();
            CreateMap<RoomDto, Room>();
            CreateMap<EquipmentTransferDto, EquipmentTransfer>();
            CreateMap<HolidayDto, Holiday>();

            CreateMap<Equipment, EquipmentDto>()
                .ForMember(d => d.RoomName, o => o.MapFrom(s => s.Room.Name))
                .ForMember(d => d.RoomType, o => o.MapFrom(s => s.Room.Type));
            CreateMap<Equipment, FloorEquipmentDto>();
            CreateMap<Room, FloorRoomDto>()
                .ForMember(d => d.X, o => o.MapFrom(s => s.RoomDimensions.X))
                .ForMember(d => d.Y, o => o.MapFrom(s => s.RoomDimensions.Y))
                .ForMember(d => d.Width, o => o.MapFrom(s => s.RoomDimensions.Width))
                .ForMember(d => d.Height, o => o.MapFrom(s => s.RoomDimensions.Height));
            CreateMap<Room, RoomWithEquipmentDto>();
            CreateMap<Room, RoomDto>();
            CreateMap<RoomDimensions, RoomDto>();
            CreateMap<EquipmentTransfer, EquipmentTransferDto>();
            CreateMap<Holiday, HolidayDto>();
            CreateMap<Doctor, DoctorRoomDto>();
            CreateMap<Doctor, DoctorDto>();
        }
    }
}
