using System;
namespace MeetingRoomBookingApp.Models
{
    public class Equipment
    {
       
        public int Id { get; set; }

        public string Name { get; set; }

        public bool BookMultiUnits { get; set; }

        public decimal Price { get; set; }

        public string BookingOption { get; set; }
    }
}
