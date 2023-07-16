using BirdClinicSystems.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using BirdClinicSystems.Validation;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text;

namespace BirdClinicSystems.Pages.DoctorBooking
{
    public class BookingModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        private readonly IHttpClientFactory _clientFactory;
        private readonly HttpClient _httpClient;
        public BookingModel(IHttpClientFactory clientFactory, HttpClient httpClient)
        {
            _clientFactory = clientFactory;
            _httpClient = httpClient;
        }
        [BindProperty]
        public Room Room { get; set; }
        [BindProperty]
        public Room_DoctorDTO BookRoom { get; set; }
        [DateValidation(CompareToOperation.LessThan, "CheckIn", "CheckOut")]
        [BindProperty]
        [Required(ErrorMessage = "CheckIn can not be empty")]
        [DataType(DataType.Date)]

        public DateTime CheckIn { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "CheckOut can not be empty")]

        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Status can not be empty")]
        public string status { get; set; }
        public List<Room> RoomList = new List<Room>();
        public List<Room_DoctorDTO> RoomBookingList = new List<Room_DoctorDTO>();
        public IList<Room> RoomNotEmpty { get; set; }
        public IList<Room> RoomInDay { get; set; }
/*        public IList<RoomType> RoomTypeList { get; set; }
*/        public List<Room> first = new List<Room>();
        public DateTime today = DateTime.Today;
        public TimeSpan ts;
        public async Task<IActionResult> OnGet()
        {
            try
            {
                /*               if (HttpContext.Session.GetString("ROLE") == "AD" || HttpContext.Session.GetString("Customer") == "Customer")
                               {
                                   return RedirectToPage("../Index");
                               }*/
                var client = _clientFactory.CreateClient("YourApiClientName");
                var response = await client.GetAsync("api/Rooms/getAllRoom");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var responseObj = JsonConvert.DeserializeObject<dynamic>(content);
                    var dataArray = responseObj.data;
                    foreach (var item in dataArray)

                    {
                        var room = new Room
                        {
                            id = item.id,
                            roomNumber = item.roomNumber,
                            roomName = item.roomName,
                            status = item.status
                        };
                        RoomList.Add(room);
                    }
                }
                else
                {
                    // Handle the error response
                    Content("Error occurred while calling the API.");
                }
                var client1 = _clientFactory.CreateClient("YourApiClientName");
                var response1 = await client.GetAsync("api/Rooms/getAllRoom");

                if (response1.IsSuccessStatusCode)
                {
                    var content1 = await response.Content.ReadAsStringAsync();
                    var responseObj1 = JsonConvert.DeserializeObject<dynamic>(content1);
                    var dataArray1 = responseObj1.data;
                    foreach (var item in dataArray1)

                    {
                        var room1 = new Room_DoctorDTO
                        {
                            DoctorID = item.doctorId,
                            ID = item.id,
                            RoomID = item.roomId,
                            Status = item.status,
                            TimeEnd = item.timeEnd,
                            TimeStart = item.timeStart
                        };
                        RoomBookingList.Add(room1);
                    }
                }
                else
                {
                    // Handle the error response
                    Content("Error occurred while calling the API.");
                }
                RoomList = RoomList.Where(p => p.status == 1).ToList();
                CheckIn = today;
                CheckOut = today.AddDays(1);
                ts = today.AddDays(1).Subtract(today);

                /*RoomBookingList = bookRoomRepository.GetStatus(CheckIn, CheckOut).Where(x => x.Status == "BOOKED" || x.Status == "CHECKIN" || x.Status == "CHECKOUT").ToList();

                foreach (var id in RoomBookingList)
                {
                    RoomNotEmpty = roomInBookingRepository.GetRoomInBooking(id.Id);
                    first.AddRange(RoomNotEmpty);
                }*/

                //  status = "booked";
                //   status = "maintenance";
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
            }

            return Page();
        }
        public async Task<IActionResult> OnPostSubmit()
        {
            try
            {
                // Prepare the data to be sent in the request
                var requestData = new
                {
                    TimeStart = CheckIn,
                    TimeEnd = CheckOut,
                    DoctorID = 1,
                    RoomID = 1
                };
                // Serialize the data into JSON format
                var content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

                // Send the POST request to the API endpoint
                var response = await _httpClient.PostAsync("http://ticketswap.somee.com/api/Room_Doctors/Register", content);

                if (response.IsSuccessStatusCode)
                {
                    // The request was successful
                    return RedirectToPage("Booking");
                }
                else
                {
                    // The request was not successful
                    return Page();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the API call
                return Content("An error occurred: " + ex.Message);
            }
        }
        /* public IActionResult OnPostSearch([FromForm] string SearchString)
         {
             if (!string.IsNullOrEmpty(SearchString))
             {
                 RoomTypeList = roomTypeRepository.GetRoomsType().ToList();
                 RoomTypeList = RoomTypeList.Where(p => p.Active == true).ToList();
                 if (Room.RoomTypeId != null)
                 {
                     RoomList = roomRepository.SearchByNameWithType(SearchString.ToLower().Trim(), Room.RoomTypeId);
                     RoomList = RoomList.Where(p => p.Active == true).ToList();
                 }
                 else
                 {
                     RoomList = roomRepository.SearchByName(SearchString.ToLower().Trim());
                     RoomList = RoomList.Where(p => p.Active == true).ToList();
                 }
                 if (CheckIn >= CheckOut || CheckIn < DateTime.Now.AddDays(-1) && CheckOut != CheckIn)
                 {
                     CheckIn = today;
                     CheckOut = today.AddDays(1);
                     ts = CheckOut.Subtract(CheckIn);
                     ViewData["ErrorMessage"] = "CheckIn or CheckOut Is valid";
                 }
                 else
                 {
                     CheckIn = CheckIn;
                     CheckOut = CheckOut;
                     ts = CheckOut.Subtract(CheckIn);
                     RoomBookingList = bookRoomRepository.GetStatus(CheckIn, CheckOut).Where(x => x.Status == "BOOKED" || x.Status == "CHECKIN" || x.Status == "CHECKOUT").ToList();

                     foreach (var id in RoomBookingList)
                     {
                         RoomNotEmpty = roomInBookingRepository.GetRoomInBooking(id.Id);
                         first.AddRange(RoomNotEmpty);
                     }
                 }

             }

             else
             {
                 RoomList = roomRepository.GetRooms().ToList();
                 RoomList = RoomList.Where(p => p.Active == true).ToList();

                 RoomTypeList = roomTypeRepository.GetRoomsType().ToList();
                 RoomTypeList = RoomTypeList.Where(p => p.Active == true).ToList();
                 if (Room.RoomTypeId != null)
                 {
                     RoomList = roomRepository.GetRooms().ToList();
                     RoomList = roomRepository.FilterByTypeId(Room.RoomTypeId);
                     RoomList = RoomList.Where(p => p.Active == true).ToList();
                 }
                 if (CheckIn >= CheckOut || CheckIn <= DateTime.Now.AddDays(-1) && CheckOut != CheckIn)
                 {
                     CheckIn = today;
                     CheckOut = today.AddDays(1);
                     ts = CheckOut.Subtract(CheckIn);
                     ViewData["ErrorMessage"] = "CheckIn or CheckOut Is valid";

                 }
                 else
                 {

                     CheckIn = CheckIn;
                     CheckOut = CheckOut;
                     ts = CheckOut.Subtract(CheckIn);
                     RoomBookingList = bookRoomRepository.GetStatus(CheckIn, CheckOut).Where(x => x.Status == "BOOKED" || x.Status == "CHECKIN" || x.Status == "CHECKOUT").ToList();
                     foreach (var id in RoomBookingList)
                     {
                         RoomNotEmpty = roomInBookingRepository.GetRoomInBooking(id.Id);
                         first.AddRange(RoomNotEmpty);
                     }

                 }

             }

             return Page();
         }*/
    }
}
