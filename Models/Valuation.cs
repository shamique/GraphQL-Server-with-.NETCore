using System;
using System.Collections.Generic;

namespace GraphQLServer.Models
{
    public partial class Valuation
    {
        public int ValuationId { get; set; }
        public string ValuationName { get; set; }
        public string VehicleNumber { get; set; }
    }
}
