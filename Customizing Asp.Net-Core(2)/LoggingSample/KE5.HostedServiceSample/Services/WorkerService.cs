using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KE5.HostedServiceSample.Services
{
    public class WorkerService : BackgroundService
    {
        private readonly ILogger<WorkerService> _logger;

        public WorkerService(ILogger<WorkerService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Background service starting");
            await Task.Factory.StartNew(async () =>
            {
                while
                (!cancellationToken.IsCancellationRequested)
                {
                    _logger.LogInformation($"Background service executing - { DateTime.Now} ");
                    try
                    {
                        await
                        Task.Delay(TimeSpan.FromSeconds(2),
                        cancellationToken);
                    }
                    catch (OperationCanceledException) { }
                }
            }, cancellationToken);
        }




        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Background service stopping");
            await Task.CompletedTask;
        }



    }


}
