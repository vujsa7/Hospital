using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HospitalAPI.DTOs;
using HospitalClassLibrary.RoomEquipment.Models;
using HospitalClassLibrary.RoomEquipment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomsController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet("rooms/{id}")]
        public async Task<RoomWithEquipmentDto> GetRoom(int id)
        {
            var room = await _roomService.GetById(id);
            return _mapper.Map<RoomWithEquipmentDto>(room);
        }

        [HttpGet("floor-rooms")] 
        public async Task<IEnumerable<FloorRoomDto>> GetFloorRooms([FromQuery(Name ="buildingId")] int buildingId)
        {
            var rooms = await _roomService.GetAll(buildingId);
            return _mapper.Map<IEnumerable<FloorRoomDto>>(rooms);
        }

        [HttpGet("floor-rooms/{id}")]
        public async Task<FloorRoomDto> GetFloorRoom(int id)
        {
            var room = await _roomService.GetById(id);
            return _mapper.Map<FloorRoomDto>(room);
        }

        [HttpGet("rooms")]
        public async Task<IEnumerable<RoomDto>> GetRooms([FromQuery(Name = "buildingId")] int buildingId)
        {
            var rooms = await _roomService.GetAll(buildingId);
            return _mapper.Map<IEnumerable<RoomDto>>(rooms);
        }

        [HttpGet("rooms/{id}/equipment")]
        public async Task<RoomWithEquipmentDto> GetRoomWithEquipment(int id)
        {
            var room = await _roomService.GetRoomWithEquipment(id);
            return _mapper.Map<RoomWithEquipmentDto>(room);
        }

        [HttpPut("rooms/{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }

            await _roomService.Update(room);

            return NoContent();
        }

    }
}
