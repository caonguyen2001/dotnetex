using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCOREinAction.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public int NumberOfBed { get; set; }
        public int RoomNumberOfGuests { get; set; }
        public float PricePerNight { get; set; }

    }
}
