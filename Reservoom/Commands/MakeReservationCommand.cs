using NLog.Fluent;
using Reservoom.Exceptions;
using Reservoom.Models;
using Reservoom.ViewModels;
using System.ComponentModel;
using System.Windows;
using Reservoom.Services;

namespace Reservoom.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        private readonly NavigationService _reservationViewNavigationService;

        public MakeReservationCommand(
            MakeReservationViewModel makeReservationViewModel, 
            Hotel hotel,
            NavigationService reservationViewNavigationService
        )
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _reservationViewNavigationService = reservationViewNavigationService;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) &&
                    _makeReservationViewModel.FloorNumber > 0 &&
                    base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate
            );

            try
            {
                _hotel.MakeReservation(reservation);

                _log.Info("Successfully reserved room.");

                MessageBox.Show("Successfully reserved room.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                _reservationViewNavigationService.Navigate();
            }
            catch (ReservationConflictException)
            {
                _log.Error("This room is already taken.");

                MessageBox.Show("This room is already taken.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.Username) || 
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
            {
                OnCanExecutedChanged();
            }
        }
    }
}
