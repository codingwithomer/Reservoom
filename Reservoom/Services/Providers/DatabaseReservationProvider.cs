using Microsoft.EntityFrameworkCore;
using Reservoom.DbContexts;
using Reservoom.DTOs;
using Reservoom.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservoom.Services.Providers
{
    public class DatabaseReservationProvider : IReservationProvider
    {
        private readonly ReservoomDbContextFactory _dbContextFactory;

        public DatabaseReservationProvider(ReservoomDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            using (ReservoomDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ReservationDTO> reservationDTOs = await context.Reservations.ToListAsync();

                return reservationDTOs.Select(x => ToReservation(x));
            }
        }

        private Reservation ToReservation(ReservationDTO reservationDTO)
        {
            return new Reservation(
                new RoomID(reservationDTO.FloorNumber, reservationDTO.RoomNumber),
                reservationDTO.Username,
                reservationDTO.StartDate,
                reservationDTO.EndDate
            );
        }
    }
}