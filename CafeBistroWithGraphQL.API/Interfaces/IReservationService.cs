using CafeBistroWithGraphQL.API.Models;
using System.Collections.Generic;

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
