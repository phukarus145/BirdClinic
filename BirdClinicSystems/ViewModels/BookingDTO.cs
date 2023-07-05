using System;

namespace BirdClinicSystems.ViewModels
{
    public class BookingDTO
    {
        public int ID { get; set; }
        public double DownPayment { get; set; }
        public DateTime TimeStart { get; set; }
        public double TotalPayment { get; set; }
        public int UserID { get; set; }
        public int Status { get; set; }
    }
}
