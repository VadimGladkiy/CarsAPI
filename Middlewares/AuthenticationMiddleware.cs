using CarsAPI.DAL;

namespace CarsAPI.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate next;

        public AuthenticationMiddleware(RequestDelegate _next)
        {
            this.next = _next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var token = httpContext.Request.Headers["token"];

            var dbContext = httpContext.RequestServices.GetService<ApplicationContext>();

            var customer = dbContext.Customers.FirstOrDefault(x => x.Token == token);

            if (customer != null)
            {
                await this.next(httpContext);
            }
            else 
            {
                httpContext.Response.StatusCode = 401;
                await httpContext.Response.WriteAsync("Such a user's token does not exist in the system");
            }
        }
    }


    public static class AuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddleware>();
        }
    }
}
