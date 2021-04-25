using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KE6.MiddlewaresSample
{
    public class StopwatchMiddleWare
    {
        private readonly RequestDelegate _next;
        public StopwatchMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            // execute the rest of the pipeline
            await _next(context);
            stopWatch.Stop(); //stop measuring
            var result = stopWatch.ElapsedMilliseconds;
            // write out the milliseconds needed
            await context.Response.WriteAsync($"Time needed: { result}");
        }



    }
}
