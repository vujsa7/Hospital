using HospitalClassLibrary.RoomEquipment.Models;

namespace HospitalAPI.DTOs
{
    public class FloorEquipmentDto
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public RoomType RoomType { get; set; }
        public int RoomFloor { get; set; }
        public string EquipmentItemName { get; set; }
        public int Quantity { get; set; }
    }
}
