using Reservoom.Commands;
using Reservoom.Models;
using Reservoom.Services;
using Reservoom.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Reservoom.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public MakeReservationViewModel MakeReservationViewModel { get; }

        public ICommand LoadReservationsCommand { get; }
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(HotelStore hotelStore, MakeReservationViewModel makeReservationViewModel, NavigationService makeReservationNavigationService)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            MakeReservationViewModel = makeReservationViewModel;

            LoadReservationsCommand = new LoadReservationsCommand(this, hotelStore);

            MakeReservationCommand = new NavigateCommand(makeReservationNavigationService);
        }

        public static ReservationListingViewModel LoadViewModel(HotelStore hotelStore, 
            MakeReservationViewModel makeReservationViewModel, 
            NavigationService makeReservationNavigationService)
        {
            ReservationListingViewModel reservationListingViewModel = new(hotelStore, makeReservationViewModel, makeReservationNavigationService);
            reservationListingViewModel.LoadReservationsCommand.Execute(null);

            return reservationListingViewModel;
        }

        public void UpdateReservations(IEnumerable<Reservation> reservations)
        {
            _reservations.Clear();

            foreach (Reservation reservation in reservations)
            {
                ReservationViewModel reservationViewModel = new(reservation);

                _reservations.Add(reservationViewModel);
            }
        }
    }
}