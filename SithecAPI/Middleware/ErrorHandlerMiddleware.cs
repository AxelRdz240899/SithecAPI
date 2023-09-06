using Microsoft.AspNetCore.Mvc;

namespace SithecAPI.Middleware
{
    public class ErrorHandlerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                ProblemDetails details = new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "Internal Server Error",
                    Detail = ex.Message
                };

                await context.Response.WriteAsJsonAsync(details);
            }
        }
    }
}
