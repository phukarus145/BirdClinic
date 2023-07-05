using System;

namespace BirdClinicSystems.ViewModels
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public byte[] Avatar { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Status { get; set; }
    }
}
