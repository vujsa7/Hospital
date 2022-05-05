using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HospitalAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using HospitalClassLibrary.RoomEquipment.Services.Interfaces;

namespace HospitalAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
        private readonly IMapper _mapper;

        public EquipmentController(IEquipmentService equipmentService, IMapper mapper)
        {
            _equipmentService = equipmentService;
            _mapper = mapper;
        }

        [HttpGet("floorEquipment")]
        public async Task<IEnumerable<FloorEquipmentDto>> GetFloorEquipment()
        {
            var equipment = await _equipmentService.GetAll();
            return _mapper.Map<IEnumerable<FloorEquipmentDto>>(equipment);
        }

        [HttpGet("equipment")]
        public async Task<IEnumerable<EquipmentDto>> GetEquipment()
        {
            var equipment = await _equipmentService.GetAll();
            return _mapper.Map<IEnumerable<EquipmentDto>>(equipment);
        }

    }
}
