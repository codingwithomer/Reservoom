using Reservoom.Models;

namespace Reservoom.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomID => _reservation.RoomID.ToString();
        public string Username => _reservation.Username;
        public string StartTime => _reservation.StartTime.ToString("dd/MM/yyyy");
        public string EndTime => _reservation.EndTime.ToString("dd/MM/yyyy");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
