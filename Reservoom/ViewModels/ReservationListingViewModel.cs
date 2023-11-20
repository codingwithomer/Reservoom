using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Reservoom.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "Ömer Bilal Can", new DateTime(2023, 11, 20), new DateTime(2023, 11, 23))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(4, 3), "Hakan Kerem Can", new DateTime(2023, 11, 20), new DateTime(2023, 11, 24))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "Niymet Kılıç Can", new DateTime(2023, 11, 20), new DateTime(2023, 11, 23))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 7), "Şanssu Can", new DateTime(2023, 11, 20), new DateTime(2023, 11, 23))));
        }
    }
}
