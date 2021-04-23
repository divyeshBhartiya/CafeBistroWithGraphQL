using CafeBistroWithGraphQL.API.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Types
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
        }
    }
}
