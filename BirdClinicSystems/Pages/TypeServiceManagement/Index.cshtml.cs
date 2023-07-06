using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BirdClinicSystems.Pages.TypeServiceManagement
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public List<TypeServiceDTO> list = new List<TypeServiceDTO>();
        public async Task<IActionResult> OnGet()
        {
            var client = _clientFactory.CreateClient("YourApiClientName");
            var response = await client.GetAsync("api/TypeServices/getAllTypeService");

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

                    var typeService = new TypeServiceDTO
                    {
                        ID = item.id,
                        TypeName = item.typeName,
                        Status = item.status,
                    };
                    list.Add(typeService);
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
