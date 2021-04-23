using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Types;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Queries
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationService reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations", resolve: context => { return reservationService.GetReservations(); });
        }
    }
}
