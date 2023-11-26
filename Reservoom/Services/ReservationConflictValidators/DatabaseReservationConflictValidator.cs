using Microsoft.EntityFrameworkCore;
using Reservoom.DbContexts;
using Reservoom.DTOs;
using Reservoom.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Reservoom.Services.ReservationConflictValidators
{
    public class DatabaseReservationConflictValidator : IReservationConflictValidator
    {
        private readonly ReservoomDbContextFactory _dbContextFactory;

        public DatabaseReservationConflictValidator(ReservoomDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<Reservation> GetConflictingReservation(Reservation reservation)
        {
            using (ReservoomDbContext context = _dbContextFactory.CreateDbContext())
            {
                ReservationDTO reservationDTO = await context.Reservations
                                                             .Where(r => r.FloorNumber == reservation.RoomID.FloorNumber)
                                                             .Where(r => r.RoomNumber == reservation.RoomID.RoomNumber)
                                                             .Where(r => r.EndDate > reservation.StartDate)
                                                             .Where(r => r.StartDate < reservation.EndDate)
                                                             .FirstOrDefaultAsync();

                if(reservationDTO == null)
                {
                    return null;
                }

                return ToReservation(reservationDTO);
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
