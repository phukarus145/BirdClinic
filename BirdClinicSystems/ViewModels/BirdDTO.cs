using System;

namespace BirdClinicSystems.ViewModels
{
    public class BirdDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public Double Height { get; set; }
        public Double Weight { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UserID { get; set; }
        public int Status { get; set; }
    }
}
