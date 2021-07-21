using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KE9.ActionFilterSample.Mvc
{
    public class LoggingActionFilter : IActionFilter
    {
        ILogger _logger;
        public LoggingActionFilter(ILoggerFactory loggerFactory)
        {
            _logger =
            loggerFactory.CreateLogger<LoggingActionFilter>();
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"Action '{context.ActionDescriptor.DisplayName}' executing");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation($"Action '{context.ActionDescriptor.DisplayName}' executed");
        }
    }
}
