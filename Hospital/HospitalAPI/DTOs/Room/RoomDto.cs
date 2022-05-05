using HospitalClassLibrary.RoomEquipment.Models;

namespace HospitalAPI.DTOs
{
	public class RoomDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public RoomType Type { get; set; }
        public int Floor { get; set; }
        public int BuildingId { get; set; }
    }
}
