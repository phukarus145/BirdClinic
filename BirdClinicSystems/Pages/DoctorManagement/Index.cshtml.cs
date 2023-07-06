using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BirdClinicSystems.Pages.DoctorManagement
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public List<DoctorDTO> DoctorList = new List<DoctorDTO>();
        public async Task<IActionResult> OnGet()
        {
            var client = _clientFactory.CreateClient("YourApiClientName");
            var response = await client.GetAsync("api/Doctors/getAllDoctor");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<dynamic>(content);
                var dataArray = responseObj.data;
                /*if (dataArray == null)
                {

                }*/
                foreach (var item in dataArray)
                {
                    DateTime birthdayValue = item.birthday;
                    string emailValue = item.email;
                    string passwordValue = item.password;
                    string nameValue = item.name;
                    string addressValue = item.address;
                    string phoneNumber = item.phoneNumber;
                    byte[] avatarValue = item.avatar;
                    var doctor = new DoctorDTO
                    {
                        ID = item.id,
                        Email = emailValue,
                        Password = passwordValue,
                        Name = nameValue,
                        Address = addressValue,
                        Birthday = birthdayValue,
                        Avatar= avatarValue,
                        PhoneNumber= phoneNumber,
                        /*CreateDate= createDateValue,*/
                        /*UpdateDate= updateDateValue,*/
                    };
                    DoctorList.Add(doctor);
                }
                return Page();
            }
            else
            {
                // Handle the error response
                return Content("Error occurred while calling the API.");
            }
        }
    }
}
