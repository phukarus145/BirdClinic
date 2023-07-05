namespace BirdClinicSystems.ViewModels
{
    public class BookingDetailDTO
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int BookingID { get; set; }
        public int Room_DoctorID { get; set; }
        public int BirdID { get; set; }
        public int Status { get; set; }
    }
}
