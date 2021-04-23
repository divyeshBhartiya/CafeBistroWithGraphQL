using CafeBistroWithGraphQL.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Interfaces
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(int reservationId, Reservation reservation);
        bool DeleteReservation(int reservationId);
    }
}
