using GraphQL.Types;
using GraphQLServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLServer.GraphQL
{
    public class ValuationType: ObjectGraphType<Valuation>
    {
        public ValuationType()
        {
            Field(x => x.ValuationId);
            Field(x => x.ValuationName, true);
            Field(x => x.VehicleNumber, true);
        }
    }
}
