using CafeBistroWithGraphQL.API.Models;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Types
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>(nameof(Reservation.Id));
            Field<StringGraphType>(nameof(Reservation.Name));
            Field<StringGraphType>(nameof(Reservation.Phone));
            Field<IntGraphType>(nameof(Reservation.TotalPeople));
            Field<StringGraphType>(nameof(Reservation.Email));
            Field<StringGraphType>(nameof(Reservation.Date));
            Field<StringGraphType>(nameof(Reservation.Time));
        }
    }
}
