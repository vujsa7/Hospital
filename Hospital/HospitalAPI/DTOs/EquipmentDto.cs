namespace HospitalAPI.DTOs
{
    public class EquipmentDto
    {
        public int Id { get; set; }
        public int EquipmentItemId { get; set; }
        public string EquipmentItemName { get; set; }
        public string EquipmentItemDescription { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int RoomType { get; set; }
        public int Quantity { get; set; }
        public int ReservedQuantity { get; set; }
    }
}
