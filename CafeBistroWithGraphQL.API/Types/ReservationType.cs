using CafeBistroWithGraphQL.API.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Types
{
    public class ReservationType: ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Phone);
            Field(m => m.Time);
            Field(m => m.Date);
            Field(m => m.TotalPeople);
            Field(m => m.Email);
        }
    }
}
