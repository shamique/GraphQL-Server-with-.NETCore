using Newtonsoft.Json.Linq;

namespace GraphQLServer.GraphQL
{
    public class GraphQLQuerySetting
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
