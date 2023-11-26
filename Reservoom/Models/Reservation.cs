using System;

namespace Reservoom.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string Username { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public TimeSpan Length => EndDate.Subtract(StartDate);

        public Reservation(RoomID roomID, string username, DateTime startDate, DateTime endDate)
        {
            RoomID = roomID;
            Username = username;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
