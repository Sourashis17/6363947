using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _5_Web_API_handson.Controllers
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            // Log exception details to a file
            File.AppendAllText("exceptions.log", $"{DateTime.Now}: {context.Exception.Message}{Environment.NewLine}");

            // Set the result to a generic error response
            context.Result = new ObjectResult("An unexpected error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
