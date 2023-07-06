using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace BirdClinicSystems.ViewModels
{
    public class UserRegisterViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Please input right password")]
        public string ConfirmPassword { get; set; }
        public IFormFile Image { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
