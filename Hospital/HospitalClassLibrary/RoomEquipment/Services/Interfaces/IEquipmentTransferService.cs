﻿using System.Threading.Tasks;
using HospitalClassLibrary.RoomEquipment.Models;

namespace HospitalClassLibrary.RoomEquipment.Services.Interfaces
{
    public interface IEquipmentTransferService
    {
        Task Create(EquipmentTransfer e);
    }
}
