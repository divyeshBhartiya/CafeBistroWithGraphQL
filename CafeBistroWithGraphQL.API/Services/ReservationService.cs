using CafeBistroWithGraphQL.API.Data;
using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Services
{
    public class ReservationService : IReservationService
    {
        private GraphQLDbContext _graphQLDbContext;
        public ReservationService(GraphQLDbContext graphQLDbContext)
        {
            _graphQLDbContext = graphQLDbContext;
        }

        public List<Reservation> GetReservations()
        {
            return _graphQLDbContext.Reservations.ToList();
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _graphQLDbContext.Reservations.Add(reservation);
            _graphQLDbContext.SaveChanges();
            return reservation;
        }
        public Reservation UpdateReservation(int reservationId, Reservation reservation)
        {
            var reservationObj = _graphQLDbContext.Reservations.Find(reservationId);
            reservationObj.Name = reservation.Name;
            reservationObj.Date = reservation.Date;
            reservationObj.TotalPeople = reservation.TotalPeople;
            reservationObj.Phone = reservation.Phone;
            reservationObj.Email = reservation.Email;
            reservationObj.Time = reservation.Time;

            _graphQLDbContext.SaveChanges();
            return reservation;
        }
        public bool DeleteReservation(int reservationId)
        {
            try
            {
                var reservationObj = _graphQLDbContext.Reservations.Find(reservationId);
                _graphQLDbContext.Reservations.Remove(reservationObj);

                _graphQLDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
