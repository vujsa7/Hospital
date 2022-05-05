﻿using HospitalClassLibrary.Events;
using HospitalClassLibrary.Events.EventBackToMap;
using HospitalClassLibrary.Events.EventEquipmentTransfer;
using HospitalClassLibrary.Events.EventFlorChange;
using HospitalClassLibrary.Events.EventRoomSelection;
using HospitalClassLibrary.GraphicalEditor.Models;
using HospitalClassLibrary.Renovations.Models;
using HospitalClassLibrary.RoomEquipment.Models;
using HospitalClassLibrary.Schedule.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalClassLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public const string DefaultSchema = "public";
        public DbSet<Building> Building { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Workday> Workday { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<OnCallShift> OnCallShift { get; set; }
        public DbSet<EquipmentTransfer> EquipmentTransfer { get; set; }
        public DbSet<RoomDimensions> RoomDimension { get; set; }
        public DbSet<NewRoomInfo> NewRoomInfo { get; set; }
        public DbSet<SplitRenovation> SplitRenovation { get; set; }
        public DbSet<MergeRenovation> MergeRenovation { get; set; }
        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<DoctorSchedule> DoctorSchedule { get; set; }

        //Events
        public DbSet<BuildingSelection> BuildingSelection { get; set; }
        public DbSet<RoomSelection> RoomSelection { get; set; }
        public DbSet<EquipmentTransferEvent> EquipmentTransferEvent { get; set; }
        public DbSet<FloorChange> FloorChange { get; set; }
        public DbSet<BackToMap> BackToMap { get; set; }
        public DbSet<Events.EventMergeRenovation.MergeRenovationEvent> MergeRenovation1 { get; set; }
        public DbSet<Events.EventSplitRenovation.SplitRenovationEvent> SplitRenovation1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoomEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentTransferEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WorkdayEntityTypeConfiguration());

            modelBuilder.Entity<Building>().HasData(
               new Building
               {
                   Id = 1,
                   Name = "Oasis Main Building",
                   Description = "The administrative center of Oasis Healthcare"
               },
               new Building
               {
                   Id = 2,
                   Name = "Oasis Treatment Center",
                   Description = "The treatment facility of Oasis Healthcare"
               }
           );
            modelBuilder.Entity<Building>().Property(e => e.Id).HasIdentityOptions(startValue: 3);

            modelBuilder.Entity<Room>().OwnsOne(r => r.RoomDimensions,
                ba =>
                {
                    ba.Property(rd => rd.X).HasColumnName("X");
                    ba.Property(rd => rd.Y).HasColumnName("Y");
                    ba.Property(rd => rd.Width).HasColumnName("Width");
                    ba.Property(rd => rd.Height).HasColumnName("Height");
                });

            modelBuilder.Entity<Room>().OwnsOne(r => r.RoomDimensions).HasData(
                new 
                {
                    RoomId = 1,
                    X = 422.0,
                    Y = 187.0,
                    Width = 228.0,
                    Height = 220.0
                },
                new
                {
                    RoomId = 2,
                    X = 422.0,
                    Y = 683.0,
                    Width = 229.0,
                    Height = 217.0
                },
                new
                {
                    RoomId = 3,
                    X = 651.0,
                    Y = 596.0,
                    Width = 209.0,
                    Height = 254.0
                },
                new
                {
                    RoomId = 4,
                    X = 1182.0,
                    Y = 237.0,
                    Width = 210.0,
                    Height = 170.0
                },
                new
                {
                    RoomId = 5,
                    X = 650.0,
                    Y = 237.0,
                    Width = 210.0,
                    Height = 170.0
                },
                new
                {
                    RoomId = 6,
                    X = 861.0,
                    Y = 237.0,
                    Width = 322.0,
                    Height = 170.0
                },
                new
                {
                    RoomId = 7,
                    X = 1190.0,
                    Y = 696.0,
                    Width = 202.0,
                    Height = 154.0
                },
                new
                {
                    RoomId = 8,
                    X = 1190.0,
                    Y = 541.0,
                    Width = 202.0,
                    Height = 154.0
                },
                new
                {
                    RoomId = 9,
                    X = 422.0,
                    Y = 407.0,
                    Width = 106.0,
                    Height = 138.0
                },
                new
                {
                    RoomId = 10,
                    X = 422.0,
                    Y = 544.0,
                    Width = 106.0,
                    Height = 138.0
                },
                new
                {
                    RoomId = 11,
                    X = 581.0,
                    Y = 407.0,
                    Width = 69.0,
                    Height = 69.0
                },
                new
                {
                    RoomId = 12,
                    X = 581.0,
                    Y = 548.0,
                    Width = 69.0,
                    Height = 134.0
                },
                new
                {
                    RoomId = 13,
                    X = 422.0,
                    Y = 187.0,
                    Width = 228.0,
                    Height = 220.0
                },
                new
                {
                    RoomId = 14,
                    X = 422.0,
                    Y = 683.0,
                    Width = 229.0,
                    Height = 217.0
                },
                new
                {
                    RoomId = 15,
                    X = 651.0,
                    Y = 596.0,
                    Width = 209.0,
                    Height = 254.0
                },
                new
                {
                    RoomId = 16,
                    X = 1182.0,
                    Y = 237.0,
                    Width = 210.0,
                    Height = 170.0
                },
                new
                {
                    RoomId = 17,
                    X = 650.0,
                    Y = 237.0,
                    Width = 210.0,
                    Height = 170.0
                },
                new
                {
                    RoomId = 18,
                    X = 861.0,
                    Y = 237.0,
                    Width = 322.0,
                    Height = 170.0
                },
                new
                {
                    RoomId = 19,
                    X = 1190.0,
                    Y = 696.0,
                    Width = 202.0,
                    Height = 154.0
                },
                new
                {
                    RoomId = 20,
                    X = 1190.0,
                    Y = 541.0,
                    Width = 202.0,
                    Height = 154.0
                },
                new
                {
                    RoomId = 21,
                    X = 422.0,
                    Y = 407.0,
                    Width = 106.0,
                    Height = 138.0
                },
                new
                {
                    RoomId = 22,
                    X = 422.0,
                    Y = 544.0,
                    Width = 106.0,
                    Height = 138.0
                },
                new
                {
                    RoomId = 23,
                    X = 581.0,
                    Y = 407.0,
                    Width = 69.0,
                    Height = 69.0
                },
                new
                {
                    RoomId = 24,
                    X = 581.0,
                    Y = 548.0,
                    Width = 69.0,
                    Height = 134.0
                }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = 1,
                    BuildingId = 1,
                    Name = "0A",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.DOCTOR_OFFICE,
                    Floor = 0
                },
                new Room
                {
                    Id = 2,
                    BuildingId = 1,
                    Name = "0B",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.DOCTOR_OFFICE,
                    Floor = 0
                },
                new Room
                {
                    Id = 3,
                    BuildingId = 1,
                    Name = "0C",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.DOCTOR_OFFICE,
                    Floor = 0
                    
                },
                new Room
                {
                    Id = 4,
                    BuildingId = 1,
                    Name = "0A",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.OPERATING_ROOM,
                    Floor = 0
                },
                new Room
                {
                    Id = 5,
                    BuildingId = 1,
                    Name = "0B",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.OPERATING_ROOM,
                    Floor = 0
                },
                new Room
                {
                    Id = 6,
                    BuildingId = 1,
                    Name = "0A",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.SURGERY_ROOM,
                    Floor = 0
                },
                new Room
                {
                    Id = 7,
                    BuildingId = 1,
                    Name = "0A",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.EMERGENCY_ROOM,
                    Floor = 0
                },
                new Room
                {
                    Id = 8,
                    BuildingId = 1,
                    Name = "0B",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.EMERGENCY_ROOM,
                    Floor = 0
                },
                new Room
                {
                    Id = 9,
                    BuildingId = 1,
                    Name = "Men's",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.RESTROOM,
                    Floor = 0
                },
                new Room
                {
                    Id = 10,
                    BuildingId = 1,
                    Name = "Women's",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.RESTROOM,
                    Floor = 0
                },
                new Room
                {
                    Id = 11,
                    BuildingId = 1,
                    Name = "L",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.LIFT,
                    Floor = 0
                },
                new Room
                {
                    Id = 12,
                    BuildingId = 1,
                    Name = "S1",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.STAIRS,
                    Floor = 0
                },

                //FLOOR - 1
                new Room
                {
                    Id = 13,
                    BuildingId = 1,
                    Name = "1A",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.DOCTOR_OFFICE,
                    Floor = 1
                },
                new Room
                {
                    Id = 14,
                    BuildingId = 1,
                    Name = "1B",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.DOCTOR_OFFICE,
                    Floor = 1
                },
                new Room
                {
                    Id = 15,
                    BuildingId = 1,
                    Name = "1C",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.DOCTOR_OFFICE,
                    Floor = 1
                },
                new Room
                {
                    Id = 16,
                    BuildingId = 1,
                    Name = "1A",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.OPERATING_ROOM,
                    Floor = 1
                },
                new Room
                {
                    Id = 17,
                    BuildingId = 1,
                    Name = "1B",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.OPERATING_ROOM,
                    Floor = 1
                },
                new Room
                {
                    Id = 18,
                    BuildingId = 1,
                    Name = "1A",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.SURGERY_ROOM,
                    Floor = 1
                },
                new Room
                {
                    Id = 19,
                    BuildingId = 1,
                    Name = "1A",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.EMERGENCY_ROOM,
                    Floor = 1
                },
                new Room
                {
                    Id = 20,
                    BuildingId = 1,
                    Name = "1B",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.EMERGENCY_ROOM,
                    Floor = 1
                },
                new Room
                {
                    Id = 21,
                    BuildingId = 1,
                    Name = "Men's",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.RESTROOM,
                    Floor = 1
                },
                new Room
                {
                    Id = 22,
                    BuildingId = 1,
                    Name = "Women's",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.RESTROOM,
                    Floor = 1
                },
                new Room
                {
                    Id = 23,
                    BuildingId = 1,
                    Name = "L",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.LIFT,
                    Floor = 1
                },
                new Room
                {
                    Id = 24,
                    BuildingId = 1,
                    Name = "S1",
                    Status = RoomStatus.UNOCCUPIED,
                    Type = RoomType.STAIRS,
                    Floor = 1
                }
            );
            modelBuilder.Entity<Room>().Property(e => e.Id).HasIdentityOptions(startValue: 25);

            modelBuilder.Entity<EquipmentItem>().HasData(
                new EquipmentItem
                {
                    Id = 1,
                    Name = "Syringe",
                    Description = "A syringe is a simple reciprocating pump consisting of a plunger that fits tightly within a cylindrical tube called a barrel."
                },
                new EquipmentItem
                {
                    Id = 2,
                    Name = "Thermometer",
                    Description = "A thermometer is a device that measures temperature or a temperature gradient."
                },
                new EquipmentItem
                {
                    Id = 3,
                    Name = "Infusion pump",
                    Description = "An external infusion pump is a medical device used to deliver fluids into a patient’s body in a controlled manner."
                },
                new EquipmentItem
                {
                    Id = 4,
                    Name = "Gauze",
                    Description = "Gauze is a thin, translucent fabric with a loose open weave."
                },
                new EquipmentItem
                {
                    Id = 5,
                    Name = "Operating table",
                    Description = "An operating table, sometimes called operating room table, is the table on which the patient lies during a surgical operation."
                },
                new EquipmentItem
                {
                    Id = 6,
                    Name = "Otoscope",
                    Description = "An otoscope or auriscope is a medical device which is used to look into the ears."
                },
                new EquipmentItem
                {
                    Id = 7,
                    Name = "Inhaler",
                    Description = "An inhaler is a medical device used for delivering medicines into the lungs through the work of a person's breathing."
                },
                new EquipmentItem
                {
                    Id = 8,
                    Name = "Scalpel",
                    Description = "A scalpel is a small and extremely sharp bladed instrument used for surgery, anatomical dissection, podiatry and various arts and crafts."
                },
                new EquipmentItem
                {
                    Id = 9,
                    Name = "Adhesive Plaster",
                    Description = "An adhesive bandage is a small medical dressing used for injuries not serious enough to require a full-size bandage."
                },
                new EquipmentItem
                {
                    Id = 10,
                    Name = "Curette",
                    Description = "A curette is a surgical instrument designed for scraping or debriding biological tissue or debris in a biopsy, excision, or cleaning procedure."
                },
                new EquipmentItem
                {
                    Id = 11,
                    Name = "Medical glove",
                    Description = "Medical gloves are disposable gloves used during medical examinations and procedures to help prevent cross-contamination between caregivers and patients."
                },
                new EquipmentItem
                {
                    Id = 12,
                    Name = "Oxygen tank",
                    Description = "An oxygen tank is an oxygen storage vessel, which is either held under pressure in gas cylinders, or as liquid oxygen in a cryogenic storage tank."
                },
                new EquipmentItem
                {
                    Id = 13,
                    Name = "Miller–Abbott tube",
                    Description = "A Miller–Abbott tube is a tube used to treat obstructions in the small intestine through intubation."
                },
                new EquipmentItem
                {
                    Id = 14,
                    Name = "Trach tube",
                    Description = "The tube is inserted through a cut in the neck below the vocal cords. This allows air to enter the lungs."
                },
                new EquipmentItem
                {
                    Id = 15,
                    Name = "Surgical suture",
                    Description = "Surgical suture is a medical device used to hold body tissues together after an injury or surgery."
                }
            );
            modelBuilder.Entity<EquipmentItem>().Property(e => e.Id).HasIdentityOptions(startValue: 16);

            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    Id = 1,
                    RoomId = 4,
                    EquipmentItemId = 1,
                    Quantity = 100,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 2,
                    RoomId = 4,
                    EquipmentItemId = 2,
                    Quantity = 2,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 3,
                    RoomId = 4,
                    EquipmentItemId = 3,
                    Quantity = 4,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 4,
                    RoomId = 4,
                    EquipmentItemId = 4,
                    Quantity = 200,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 5,
                    RoomId = 4,
                    EquipmentItemId = 8,
                    Quantity = 6,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 6,
                    RoomId = 4,
                    EquipmentItemId = 5,
                    Quantity = 1,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 13,
                    RoomId = 4,
                    EquipmentItemId = 14,
                    Quantity = 4,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 14,
                    RoomId = 4,
                    EquipmentItemId = 15,
                    Quantity = 1,
                    ReservedQuantity = 0
                },
                ///////////////////////////
                new Equipment
                {
                    Id = 7,
                    RoomId = 5,
                    EquipmentItemId = 1,
                    Quantity = 104,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 8,
                    RoomId = 5,
                    EquipmentItemId = 2,
                    Quantity = 5,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 9,
                    RoomId = 5,
                    EquipmentItemId = 3,
                    Quantity = 6,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 10,
                    RoomId = 5,
                    EquipmentItemId = 4,
                    Quantity = 150,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 11,
                    RoomId = 5,
                    EquipmentItemId = 8,
                    Quantity = 10,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 12,
                    RoomId = 5,
                    EquipmentItemId = 5,
                    Quantity = 1,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 15,
                    RoomId = 4,
                    EquipmentItemId = 14,
                    Quantity = 3,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 16,
                    RoomId = 4,
                    EquipmentItemId = 15,
                    Quantity = 1,
                    ReservedQuantity = 0
                },
                ///////////////////////////////
                new Equipment
                {
                    Id = 17,
                    RoomId = 16,
                    EquipmentItemId = 1,
                    Quantity = 100,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 18,
                    RoomId = 16,
                    EquipmentItemId = 2,
                    Quantity = 2,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 19,
                    RoomId = 16,
                    EquipmentItemId = 3,
                    Quantity = 4,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 20,
                    RoomId = 16,
                    EquipmentItemId = 4,
                    Quantity = 200,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 21,
                    RoomId = 16,
                    EquipmentItemId = 8,
                    Quantity = 6,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 22,
                    RoomId = 16,
                    EquipmentItemId = 5,
                    Quantity = 1,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 23,
                    RoomId = 16,
                    EquipmentItemId = 14,
                    Quantity = 4,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 24,
                    RoomId = 16,
                    EquipmentItemId = 15,
                    Quantity = 1,
                    ReservedQuantity = 0
                },
                //////////////////////////
                new Equipment
                {
                    Id = 25,
                    RoomId = 17,
                    EquipmentItemId = 1,
                    Quantity = 104,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 26,
                    RoomId = 17,
                    EquipmentItemId = 2,
                    Quantity = 5,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 27,
                    RoomId = 17,
                    EquipmentItemId = 3,
                    Quantity = 6,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 28,
                    RoomId = 17,
                    EquipmentItemId = 4,
                    Quantity = 150,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 29,
                    RoomId = 17,
                    EquipmentItemId = 8,
                    Quantity = 10,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 30,
                    RoomId = 17,
                    EquipmentItemId = 5,
                    Quantity = 1,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 31,
                    RoomId = 17,
                    EquipmentItemId = 14,
                    Quantity = 3,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 32,
                    RoomId = 17,
                    EquipmentItemId = 15,
                    Quantity = 1,
                    ReservedQuantity = 0
                },
                ////////////////////////////
                new Equipment
                {
                    Id = 33,
                    RoomId = 17,
                    EquipmentItemId = 11,
                    Quantity = 230,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 34,
                    RoomId = 1,
                    EquipmentItemId = 11,
                    Quantity = 200,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 35,
                    RoomId = 2,
                    EquipmentItemId = 11,
                    Quantity = 110,
                    ReservedQuantity = 0
                },
                new Equipment
                {
                    Id = 36,
                    RoomId = 3,
                    EquipmentItemId = 11,
                    Quantity = 235,
                    ReservedQuantity = 0
                }
            );
            modelBuilder.Entity<Equipment>().Property(e => e.Id).HasIdentityOptions(startValue: 37);

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "George",
                    Surname = "Ross",
                    DateOfBirth = new System.DateTime(1959, 1, 17),
                    Phone = "0618384494",
                    Email = "georgeross@gmail.com",
                    Gender = Gender.MALE,
                    Specialization = Specialization.CARDIOLOGIST,
                    RoomId = 1
                },
                new Doctor
                {
                    Id = 2,
                    Name = "Jonny",
                    Surname = "Depp",
                    DateOfBirth = new System.DateTime(1965, 4, 22),
                    Phone = "0628345664",
                    Email = "jonnydepp@gmail.com",
                    Gender = Gender.MALE,
                    Specialization = Specialization.NONE,
                    RoomId = 2
                },
                new Doctor
                {
                    Id = 3,
                    Name = "Luigi",
                    Surname = "Domino",
                    DateOfBirth = new System.DateTime(1963, 8, 11),
                    Phone = "0618331884",
                    Email = "luigidomino@gmail.com",
                    Gender = Gender.MALE,
                    Specialization = Specialization.DERMATOLOGIST,
                    RoomId = 3
                },
                new Doctor
                {
                    Id = 4,
                    Name = "Monnica",
                    Surname = "Beckham",
                    DateOfBirth = new System.DateTime(1987, 4, 2),
                    Phone = "0633415156",
                    Email = "monnica13@gmail.com",
                    Gender = Gender.FEMALE,
                    Specialization = Specialization.INTERNIST,
                    RoomId = 4
                },
                new Doctor
                {
                    Id = 5,
                    Name = "Melanie",
                    Surname = "Remi",
                    DateOfBirth = new System.DateTime(1968, 2, 7),
                    Phone = "066144141",
                    Email = "melanie@gmail.com",
                    Gender = Gender.FEMALE,
                    Specialization = Specialization.NONE,
                    RoomId = 5
                },
                new Doctor
                {
                    Id = 6,
                    Name = "Latcika",
                    Surname = "Uri",
                    DateOfBirth = new System.DateTime(1988, 1, 30),
                    Phone = "066165642",
                    Email = "latcika@gmail.com",
                    Gender = Gender.MALE,
                    Specialization = Specialization.NONE,
                    RoomId = 6
                }
            );
            modelBuilder.Entity<Doctor>().Property(e => e.Id).HasIdentityOptions(startValue: 7);

            modelBuilder.Entity<Shift>().HasData(
                new Shift
                {
                    Id = 1,
                    Start = new System.DateTime(2022, 5, 10, 8, 0, 0),
                    End = new System.DateTime(2022, 5, 10, 17, 0, 0),
                    Name = "Morning shift"
                },
                new Shift
                {
                    Id = 2,
                    Start = new System.DateTime(2022, 5, 10, 17, 0, 0),
                    End = new System.DateTime(2022, 5, 10, 23, 0, 0),
                    Name = "Afternoon shift"
                },
                new Shift
                {
                    Id = 3,
                    Start = new System.DateTime(2022, 5, 11, 8, 0, 0),
                    End = new System.DateTime(2022, 5, 11, 17, 0, 0),
                    Name = "Morning shift"
                },
                new Shift
                {
                    Id = 4,
                    Start = new System.DateTime(2022, 5, 11, 17, 0, 0),
                    End = new System.DateTime(2022, 5, 11, 23, 0, 0),
                    Name = "Afternoon shift"
                },
                new Shift
                {
                    Id = 5,
                    Start = new System.DateTime(2022, 5, 12, 8, 0, 0),
                    End = new System.DateTime(2022, 5, 12, 17, 0, 0),
                    Name = "Morning shift"
                },
                new Shift
                {
                    Id = 6,
                    Start = new System.DateTime(2022, 5, 12, 17, 0, 0),
                    End = new System.DateTime(2022, 5, 12, 23, 0, 0),
                    Name = "Afternoon shift"
                },
                new Shift
                {
                    Id = 7,
                    Start = new System.DateTime(2022, 5, 13, 8, 0, 0),
                    End = new System.DateTime(2022, 5, 13, 17, 0, 0),
                    Name = "Morning shift"
                },
                new Shift
                {
                    Id = 8,
                    Start = new System.DateTime(2022, 5, 13, 17, 0, 0),
                    End = new System.DateTime(2022, 5, 13, 23, 0, 0),
                    Name = "Afternoon shift"
                },
                new Shift
                {
                    Id = 9,
                    Start = new System.DateTime(2022, 5, 14, 8, 0, 0),
                    End = new System.DateTime(2022, 5, 14, 17, 0, 0),
                    Name = "Morning shift"
                },
                new Shift
                {
                    Id = 10,
                    Start = new System.DateTime(2022, 5, 15, 17, 0, 0),
                    End = new System.DateTime(2022, 5, 15, 23, 0, 0),
                    Name = "Afternoon shift"
                },
                new Shift
                {
                    Id = 11,
                    Start = new System.DateTime(2022, 5, 16, 8, 0, 0),
                    End = new System.DateTime(2022, 5, 16, 17, 0, 0),
                    Name = "Morning shift"
                },
                new Shift
                {
                    Id = 12,
                    Start = new System.DateTime(2022, 5, 17, 17, 0, 0),
                    End = new System.DateTime(2022, 5, 17, 23, 0, 0),
                    Name = "Afternoon shift"
                },
                new Shift
                {
                    Id = 13,
                    Start = new System.DateTime(2022, 5, 29, 8, 0, 0),
                    End = new System.DateTime(2022, 5, 29, 17, 0, 0),
                    Name = "Morning shift"
                },
                new Shift
                {
                    Id = 14,
                    Start = new System.DateTime(2022, 5, 29, 17, 0, 0),
                    End = new System.DateTime(2022, 5, 29, 23, 0, 0),
                    Name = "Afternoon shift"
                },
                new Shift
                {
                    Id = 15,
                    Start = new System.DateTime(2022, 5, 30, 8, 0, 0),
                    End = new System.DateTime(2022, 5, 30, 17, 0, 0),
                    Name = "Morning shift"
                },
                new Shift
                {
                    Id = 16,
                    Start = new System.DateTime(2022, 5, 30, 17, 0, 0),
                    End = new System.DateTime(2022, 5, 30, 23, 0, 0),
                    Name = "Afternoon shift"
                }
            );
            modelBuilder.Entity<Shift>().Property(e => e.Id).HasIdentityOptions(startValue: 17);

            modelBuilder.Entity<OnCallShift>().HasData(
                new OnCallShift
                {
                    Id = 1,
                    Start = new System.DateTime(2022, 5, 10, 23, 0, 0),
                    DoctorId = 1
                },
                new OnCallShift
                {
                    Id = 2,
                    Start = new System.DateTime(2022, 5, 10, 23, 0, 0),
                    DoctorId = 2
                },
                new OnCallShift
                {
                    Id = 3,
                    Start = new System.DateTime(2022, 5, 11, 23, 0, 0),
                    DoctorId = 1
                },
                new OnCallShift
                {
                    Id = 4,
                    Start = new System.DateTime(2022, 5, 11, 23, 0, 0),
                    DoctorId = 2
                },
                new OnCallShift
                {
                    Id = 5,
                    Start = new System.DateTime(2022, 5, 12, 23, 0, 0),
                    DoctorId = 3
                },
                new OnCallShift
                {
                    Id = 6,
                    Start = new System.DateTime(2022, 5, 12, 23, 0, 0),
                    DoctorId = 4
                },
                new OnCallShift
                {
                    Id = 7,
                    Start = new System.DateTime(2022, 5, 13, 23, 0, 0),
                    DoctorId = 3
                },
                new OnCallShift
                {
                    Id = 8,
                    Start = new System.DateTime(2022, 5, 13, 23, 0, 0),
                    DoctorId = 4,
                },
                new OnCallShift
                {
                    Id = 9,
                    Start = new System.DateTime(2022, 5, 14, 23, 0, 0),
                    DoctorId = 5
                },
                new OnCallShift
                {
                    Id = 10,
                    Start = new System.DateTime(2022, 5, 14, 23, 0, 0),
                    DoctorId = 6
                },
                new OnCallShift
                {
                    Id = 11,
                    Start = new System.DateTime(2022, 5, 15, 23, 0, 0),
                    DoctorId = 5
                },
                new OnCallShift
                {
                    Id = 12,
                    Start = new System.DateTime(2022, 5, 15, 23, 0, 0),
                    DoctorId = 6
                }
            );
            modelBuilder.Entity<OnCallShift>().Property(e => e.Id).HasIdentityOptions(startValue: 13);

            modelBuilder.Entity<Workday>().HasData(
                new Workday(1, 1, 1),
                new Workday(2, 1, 3),
                new Workday(3, 1, 5),
                new Workday(4, 1, 7),
                new Workday(5, 1, 9),
                new Workday(6, 2, 2),
                new Workday(7, 2, 4),
                new Workday(8, 2, 6),
                new Workday(9, 2, 8),
                new Workday(10, 3, 1),
                new Workday(11, 3, 3),
                new Workday(12, 3, 5),
                new Workday(13, 3, 7),
                new Workday(14, 3, 9),
                new Workday(15, 4, 2),
                new Workday(16, 4, 4),
                new Workday(17, 4, 6),
                new Workday(18, 4, 8)
            );
            modelBuilder.Entity<Workday>().Property(e => e.Id).HasIdentityOptions(startValue: 19);

            modelBuilder.Entity<Workday>().OwnsMany(w => w.Appointments,
                a =>
                {
                    a.WithOwner().HasForeignKey("WorkdayId");
                    a.Property<int>("Id");
                    a.HasKey("Id");
                });

            modelBuilder.Entity<Workday>().OwnsMany(w => w.Appointments).HasData(
                // anonymous type
                new
                {
                    Id = 1,
                    StartTime = new System.DateTime(2022, 5, 23, 8, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 23, 8, 30, 0),
                    WorkdayId = 1
                },
                new
                {
                    Id = 2,
                    StartTime = new System.DateTime(2022, 5, 23, 10, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 23, 10, 30, 0),
                    WorkdayId = 10
                },
                new
                {
                    Id = 3,
                    StartTime = new System.DateTime(2022, 5, 23, 11, 30, 0),
                    EndTime = new System.DateTime(2022, 5, 23, 12, 0, 0),
                    WorkdayId = 1
                },
                new
                {
                    Id = 4,
                    StartTime = new System.DateTime(2022, 5, 23, 12, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 23, 12, 30, 0),
                    WorkdayId = 10
                },
                new
                {
                    Id = 5,
                    StartTime = new System.DateTime(2022, 5, 23, 14, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 23, 14, 30, 0),
                    WorkdayId = 10
                },
                new
                {
                    Id = 6,
                    StartTime = new System.DateTime(2022, 5, 23, 17, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 23, 17, 30, 0),
                    WorkdayId = 6
                },
                new
                {
                    Id = 7,
                    StartTime = new System.DateTime(2022, 5, 23, 18, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 23, 18, 30, 0),
                    WorkdayId = 15
                },
                new
                {
                    Id = 8,
                    StartTime = new System.DateTime(2022, 5, 24, 10, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 24, 10, 30, 0),
                    WorkdayId = 2
                },
                new
                {
                    Id = 9,
                    StartTime = new System.DateTime(2022, 5, 24, 11, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 24, 11, 30, 0),
                    WorkdayId = 2
                },
                new
                {
                    Id = 10,
                    StartTime = new System.DateTime(2022, 5, 24, 12, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 24, 12, 30, 0),
                    WorkdayId = 11
                },
                new
                {
                    Id = 11,
                    StartTime = new System.DateTime(2022, 5, 24, 13, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 24, 13, 30, 0),
                    WorkdayId = 11
                },
                new
                {
                    Id = 12,
                    StartTime = new System.DateTime(2022, 5, 24, 13, 30, 0),
                    EndTime = new System.DateTime(2022, 5, 24, 14, 0, 0),
                    WorkdayId = 2
                },
                new
                {
                    Id = 13,
                    StartTime = new System.DateTime(2022, 5, 24, 17, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 24, 17, 30, 0),
                    WorkdayId = 7
                },
                new
                {
                    Id = 14,
                    StartTime = new System.DateTime(2022, 5, 24, 18, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 24, 18, 30, 0),
                    WorkdayId = 16
                },
                new
                {
                    Id = 15,
                    StartTime = new System.DateTime(2022, 5, 25, 8, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 8, 30, 0),
                    WorkdayId = 3
                },
                new
                {
                    Id = 16,
                    StartTime = new System.DateTime(2022, 5, 25, 9, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 9, 30, 0),
                    WorkdayId = 12
                },
                new
                {
                    Id = 17,
                    StartTime = new System.DateTime(2022, 5, 25, 9, 30, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 10, 0, 0),
                    WorkdayId = 3
                },
                new
                {
                    Id = 18,
                    StartTime = new System.DateTime(2022, 5, 25, 10, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 10, 30, 0),
                    WorkdayId = 12
                },
                new
                {
                    Id = 19,
                    StartTime = new System.DateTime(2022, 5, 25, 11, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 11, 30, 0),
                    WorkdayId = 12
                },
                new
                {
                    Id = 20,
                    StartTime = new System.DateTime(2022, 5, 25, 12, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 12, 30, 0),
                    WorkdayId = 3
                },
                new
                {
                    Id = 21,
                    StartTime = new System.DateTime(2022, 5, 25, 12, 30, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 13, 0, 0),
                    WorkdayId = 12
                },
                new
                {
                    Id = 22,
                    StartTime = new System.DateTime(2022, 5, 25, 13, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 13, 30, 0),
                    WorkdayId = 12
                },
                new
                {
                    Id = 23,
                    StartTime = new System.DateTime(2022, 5, 25, 15, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 15, 30, 0),
                    WorkdayId = 3
                },
                new
                {
                    Id = 24,
                    StartTime = new System.DateTime(2022, 5, 25, 17, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 17, 30, 0),
                    WorkdayId = 8
                },
                new
                {
                    Id = 25,
                    StartTime = new System.DateTime(2022, 5, 25, 19, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 23, 19, 30, 0),
                    WorkdayId = 8
                },
                new
                {
                    Id = 26,
                    StartTime = new System.DateTime(2022, 5, 25, 20, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 25, 20, 30, 0),
                    WorkdayId = 17
                },
                new
                {
                    Id = 27,
                    StartTime = new System.DateTime(2022, 5, 26, 10, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 26, 10, 30, 0),
                    WorkdayId = 13
                },
                new
                {
                    Id = 28,
                    StartTime = new System.DateTime(2022, 5, 26, 11, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 26, 11, 30, 0),
                    WorkdayId = 13
                },
                new
                {
                    Id = 29,
                    StartTime = new System.DateTime(2022, 5, 26, 12, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 26, 12, 30, 0),
                    WorkdayId = 4
                },
                new
                {
                    Id = 30,
                    StartTime = new System.DateTime(2022, 5, 26, 13, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 26, 13, 30, 0),
                    WorkdayId = 4
                },
                new
                {
                    Id = 31,
                    StartTime = new System.DateTime(2022, 5, 26, 13, 30, 0),
                    EndTime = new System.DateTime(2022, 5, 26, 14, 0, 0),
                    WorkdayId = 13
                },
                new
                {
                    Id = 32,
                    StartTime = new System.DateTime(2022, 5, 26, 17, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 26, 17, 30, 0),
                    WorkdayId = 18
                },
                new
                {
                    Id = 33,
                    StartTime = new System.DateTime(2022, 5, 26, 18, 0, 0),
                    EndTime = new System.DateTime(2022, 5, 26, 18, 30, 0),
                    WorkdayId = 18
                }
            );

            modelBuilder.Entity<DoctorSchedule>().HasData(
                new DoctorSchedule(1, 1),
                new DoctorSchedule(2, 2),
                new DoctorSchedule(3, 3),
                new DoctorSchedule(4, 4),
                new DoctorSchedule(5, 5),
                new DoctorSchedule(6, 6)
            );
            modelBuilder.Entity<DoctorSchedule>().Property(e => e.Id).HasIdentityOptions(startValue: 7);

            modelBuilder.Entity<DoctorSchedule>()
                .HasMany(doctorSchedule => doctorSchedule.OnCallShifts)
                .WithOne()
                .HasForeignKey(onCallShift => onCallShift.DoctorId)
                .HasPrincipalKey(doctorSchedule => doctorSchedule.DoctorId);

            modelBuilder.Entity<DoctorSchedule>()
                .HasMany(doctorSchedule => doctorSchedule.Workdays)
                .WithOne()
                .HasForeignKey(workday => workday.DoctorId)
                .HasPrincipalKey(doctorSchedule => doctorSchedule.DoctorId);
        }
    }
}