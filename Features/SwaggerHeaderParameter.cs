using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace CarsAPI.Features
{
    public class SwaggerHeaderParameter : IOperationFilter
    {
        void IOperationFilter.Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                AllowEmptyValue = false,
                Name = "Token",
                In = ParameterLocation.Header,
                Required = true
            });
        }
    }
}
