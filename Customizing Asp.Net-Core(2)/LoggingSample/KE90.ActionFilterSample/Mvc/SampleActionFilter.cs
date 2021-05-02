using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KE9.ActionFilterSample.Mvc
{
    public class SampleActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // do something before the action executes
        }
        public void OnActionExecuted( ActionExecutedContext context)
        {
            // do something after the action executes
        }
    }
}
