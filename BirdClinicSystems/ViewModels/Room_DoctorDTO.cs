using System;

namespace BirdClinicSystems.ViewModels
{
    public class Room_DoctorDTO
    {
        public int ID { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public int DoctorID { get; set; }
        public int RoomID { get; set; }
        public int Status { get; set; }
    }
}
