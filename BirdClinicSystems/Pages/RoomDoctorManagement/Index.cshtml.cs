using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace BirdClinicSystems.Pages.RoomDoctorManagement
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public List<Room_DoctorDTO> list = new List<Room_DoctorDTO>();
        public async Task<IActionResult> OnGet()
        {
            var client = _clientFactory.CreateClient("YourApiClientName");
            var response = await client.GetAsync("api/Room_Doctors/getAllRoom_Doctor");

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
                    DateTime timeStartValue = item.timeStart;
                    DateTime timeEndValue = item.timeEnd;
                    var room_doctor = new Room_DoctorDTO
                    {
                        ID = item.id,
                        DoctorID = item.doctorID,
                        RoomID = item.roomID,
                        Status = item.status,
                        TimeStart = timeStartValue,
                        TimeEnd = timeEndValue,
                    };
                    list.Add(room_doctor);
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
