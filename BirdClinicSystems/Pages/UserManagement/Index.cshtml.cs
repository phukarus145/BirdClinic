using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BirdClinicSystems.Pages.UserManagement
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public List<UserDTO> UserList = new List<UserDTO>();
        public async Task<IActionResult> OnGet()
        {
            var client = _clientFactory.CreateClient("YourApiClientName");
            var response = await client.GetAsync("api/Users/getAllUser");

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
                    int statusValue = item.status;
                    string nameValue = item.name;
                    string addressValue = item.address;
                    byte[] avatarValue = item.avatar;
                    string phoneValue = item.phoneNumber;
                    var user = new UserDTO
                    {
                        ID = item.id,
                        Email = emailValue,
                        Status = statusValue,
                        Name = nameValue,
                        Address = addressValue,
                        Birthday = birthdayValue,
                        Avatar = avatarValue,
                        PhoneNumber = phoneValue,
                    };
                    UserList.Add(user);
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
