using GraphQLServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLServer.Operators.Interface
{
    public interface IValuationOperator
    {
        List<Valuation> GetAllValuations();
        Valuation GetValuationById(int valuationId);
    }
}
