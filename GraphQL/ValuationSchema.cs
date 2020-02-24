using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLServer.GraphQL
{
    public class ValuationSchema : Schema
    {
        public ValuationSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ValuationQuery>();
            Mutation = resolver.Resolve<ValuationMutation>();
        }
    }
}
