using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace BirdClinicSystems.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpClientFactory _clientFactory;
        public RegisterModel(IHttpClientFactory clientFactory, IWebHostEnvironment webHostEnvironment)
        {
            _clientFactory = clientFactory;
            _webHostEnvironment = webHostEnvironment;
        }

        public UserRegisterViewModel account = new UserRegisterViewModel();
        public void OnGet()
        {
        }
        private string UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0) return null;
            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "img-user");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyToAsync(stream);
            }
            return uniqueFileName;
        }

        public async Task<IActionResult> OnPost(UserRegisterViewModel model)
        {
            if (model == null)
            {
                return NotFound();
            }
            /*if (model.Image != null && model.Image.Length > 0)
            {
                string uniFileName = UploadImage(model.Image);
                model.Image = uniFileName;
            }*/
            var temp = new UserRegisterViewModel
            {
                Email = model.Email,
                Name = model.Name,
                Birthday = model.Birthday,
                Password = model.Password,
                Image = model.Image,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
            };

            var client = _clientFactory.CreateClient("YourApiClientName");
            var response = await client.PostAsJsonAsync("api/Users/Register", temp);
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
