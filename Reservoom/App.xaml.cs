using Reservoom.Exceptions;
using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Can Suite");

            try
            {
                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "Ömer Bilal Can",
                    new DateTime(2023, 11, 17),
                    new DateTime(2023, 11, 18)
                ));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "Ömer Bilal Can",
                    new DateTime(2023, 11, 18),
                    new DateTime(2023, 11, 25)
                ));
            }
            catch (ReservationConflictException ex)
            {
                throw ex;
            }

            IEnumerable<Reservation> reservations = hotel.GetAllReservations();

            base.OnStartup(e);
        }
    }
}
