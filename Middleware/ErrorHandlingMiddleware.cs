using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using MiddleWareApp.Model;
using Microsoft.EntityFrameworkCore;
using MiddleWareApp.Data;

namespace MiddleWareApp.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
            
        }

        public async Task InvokeAsync(HttpContext httpContext, MiddleWareAppContext db)
        {
            // LogErrorToDatabase();
           

            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await LogErrorAsync(ex,db);
            }
           
        }

        public async Task LogErrorAsync(Exception ex,MiddleWareAppContext db)
        {

            db.Add(
                new ErrorModel()
                {
                    ErrorName = "name",
                    ErrorDescription = "Description",
                    ErrorType = "Type",
                    ApiId = "123frt"
                }
                );
           await db.SaveChangesAsync();
        }

    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ErrorHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
