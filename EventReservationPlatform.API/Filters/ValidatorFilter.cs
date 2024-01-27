using Microsoft.AspNetCore.Mvc.Filters;

namespace EventReservationPlatform.API.Filters
{
    public class ValidatorFilter : IActionFilter
    {
   
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
