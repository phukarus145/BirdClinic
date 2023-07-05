using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
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
                    var user = new UserDTO
                    {
                        /*ID = item.id,*/
                        Email = item.Email,
                        /*Status= item.status,*/
                        Name = item.Name,
                        Address = item.Address,
                        /*Birthday = item.Birthday,*/
                        Avatar = item.Avatar,
                        PhoneNumber = item.PhoneNumber,
                        /*CreateDate = item.CreateDate,*/
                        /*UpdateDate = item.UpdateDate,*/
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
