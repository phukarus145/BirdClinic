using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BirdClinicSystems.Pages.BirdManagement
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public List<BirdDTO> BirdList = new List<BirdDTO>();
        public async Task<IActionResult> OnGet()
        {
            var client = _clientFactory.CreateClient("YourApiClientName");
            var response = await client.GetAsync("api/Birds/getAllBird");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<dynamic>(content);
                var dataArray = responseObj.data;
                foreach (var item in dataArray)

                {
                    DateTime birthdayValue = item.birthday;
                    int statusValue = item.status;
                    int userIDValue = item.userID;
                    var bird = new BirdDTO
                    {
                        ID = item.id,
                        Name = item.name,
                        Birthday = birthdayValue,
                        Description = item.description,
                        Image = item.image,
                        Height = item.height,
                        Weight = item.weight,
                        UserID = userIDValue,
                        Status = statusValue
                    };
                    BirdList.Add(bird);
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
