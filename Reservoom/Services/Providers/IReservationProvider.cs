﻿using Reservoom.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reservoom.Services.Providers
{
    public interface IReservationProvider
    {
        Task<IEnumerable<Reservation>> GetAllReservations();
    }
}
