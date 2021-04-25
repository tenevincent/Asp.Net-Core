using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KE6.MiddlewaresSample
{
    public static class StopwatchMiddlewareExtension
    {
        public static IApplicationBuilder
        UseStopwatch(this IApplicationBuilder app)
        {
            app.UseMiddleware<StopwatchMiddleWare>();
            {
                return app;
            }
        }


    }
}
