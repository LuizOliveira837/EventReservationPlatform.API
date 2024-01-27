using EventReservationPlatform.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.VisualBasic;
using System.Net;

namespace EventReservationPlatform.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var statusCode = HttpStatusCode.InternalServerError;

            if (context.Exception is NotFoundByIdException)
            {
                statusCode = HttpStatusCode.NotFound;
            }


            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)statusCode;
            context.Result = new JsonResult( new
               { error = context.Exception.Message }
            );

        }

    
    }
}
