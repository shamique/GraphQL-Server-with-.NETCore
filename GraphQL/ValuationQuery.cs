using GraphQL.Types;
using GraphQLServer.Operators;
using NHLStats.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLServer.GraphQL
{
    public class ValuationQuery : ObjectGraphType
    {
        public ValuationQuery(ContextServiceLocator contextServiceLocator)
        {
            Field<ListGraphType<ValuationType>>(
                "valuations",
                resolve: context => contextServiceLocator.valuationOperator.GetAllValuations());

            Field<ValuationType>(
                "valuation",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "valuationId" }),
                resolve: context => contextServiceLocator.valuationOperator.GetValuationById(context.GetArgument<int>("valuationId")));
        }
    }
}
