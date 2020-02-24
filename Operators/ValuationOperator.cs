using GraphQLServer.Models;
using GraphQLServer.Operators.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLServer.Operators
{
    public class ValuationOperator: IValuationOperator
    {
        public Valuation GetValuationById(int valuationId)
        {
            using var db = new DBContext();
            return db.Valuation.First(v => v.ValuationId == valuationId);
        }

        public List<Valuation> GetAllValuations()
        {
            using var db = new DBContext();
            return db.Valuation.ToList();
        }
    }
}
