using GraphQLServer.Operators.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace NHLStats.Api.Helpers
{
    // https://github.com/graphql-dotnet/graphql-dotnet/issues/648#issuecomment-431489339
    public class ContextServiceLocator
    {
        public IValuationOperator valuationOperator => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IValuationOperator>();        
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextServiceLocator(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}