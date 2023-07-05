using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BirdClinicSystems.Pages.BookingDetailManagement
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public List<BookingDetailDTO> BookingDetailsList = new List<BookingDetailDTO>();
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
                    var bookingDetail = new BookingDetailDTO
                    {
                        ID= item.id,
                        BirdID= item.id,
                        BookingID= item.id,
                        Description= item.description,
                        Room_DoctorID= item.room_doctorID,
                        Status= item.status,
                    };
                    BookingDetailsList.Add(bookingDetail);
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
