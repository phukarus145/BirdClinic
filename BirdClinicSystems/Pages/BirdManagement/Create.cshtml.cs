using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BirdClinicSystems.Pages.BirdManagement
{
    public class CreateModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public CreateModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public BirdDTO Bird = new BirdDTO();
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(BirdDTO bird)
        {
            if(bird == null)
            {
                return NotFound();
            }
            var temp = new BirdDTO
            {
                Name= bird.Name,
                Birthday= bird.Birthday,
                Description= bird.Description,
                Image = bird.Image,
                Height= bird.Height,
                Weight= bird.Weight,
                UserID= bird.UserID,
            };
            
            var client = _clientFactory.CreateClient("YourApiClientName");
            var response = await client.PostAsJsonAsync("api/Birds/Register", temp);
            if (response.IsSuccessStatusCode)
            {
                /*var content = await response.Content.();
                var responseObj = JsonConvert.DeserializeObject<dynamic>(content);
                var dataArray = responseObj.data;
                foreach (var item in dataArray)

                {
                    var bird = new Bird
                    {
                        Id = item.id,
                        Name = item.name,
                        Birthday = item.birthday,
                        Description = item.description,
                        Image = item.image,
                        Height = item.height,
                        Weight = item.weight,
                        *//*CreateDate= item.createdate,
                        UpdateDate= item.updatedate,*/
                        /*UserId= item.userId,
                        Status = item.status*//*
                    };
                    
                }*/
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
