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

        /// <summary>
        /// Check if a reservation conflicts.
        /// </summary>
        /// <param name="reservation">The incoming reservation.</param>
        /// <returns>True/false for conflicts.</returns>
        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }

            return reservation.StartDate < EndDate && reservation.EndDate > StartDate;
        }
    }
}
