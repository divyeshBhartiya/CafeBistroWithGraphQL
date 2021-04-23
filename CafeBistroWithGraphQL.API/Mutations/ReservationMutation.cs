using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using CafeBistroWithGraphQL.API.Types;
using GraphQL;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Mutations
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationService reservationService)
        {
            // Arguments for Mutation
            var reservationInput = new QueryArgument<ReservationInputType> { Name = nameof(Reservation) };
            var reservationId = new QueryArgument<IntGraphType> { Name = nameof(Reservation.Id) };

            // Add Reservation
            Field<ReservationType>("createReservation", arguments: new QueryArguments(reservationInput),
             resolve: context =>
             {
                 return reservationService.AddReservation(context.GetArgument<Reservation>(nameof(Reservation)));
             });

            // Update Reservation
            Field<ReservationType>("updateReservation", arguments: new QueryArguments(reservationId, reservationInput),
                resolve: context =>
                {
                    var reservation = context.GetArgument<Reservation>(nameof(Reservation));
                    var reservationId = context.GetArgument<int>(nameof(Reservation.Id));
                    return reservationService.UpdateReservation(reservationId, reservation);
                });

            // Delete Reservation
            Field<BooleanGraphType>("deleteReservation", arguments: new QueryArguments(reservationId),
                resolve: context =>
                {
                    var reservationId = context.GetArgument<int>(nameof(Reservation.Id));
                    return reservationService.DeleteReservation(reservationId);
                });
        }
    }
}
