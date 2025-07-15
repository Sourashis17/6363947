using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace _3_Web_API_handson.Models
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // Log exception details to a file
            var exception = context.Exception;
            File.AppendAllText("exceptions.log", $"{DateTime.Now}: {exception.Message}{Environment.NewLine}");

            // Set the result to a generic error response
            context.Result = new ObjectResult("An unexpected error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
