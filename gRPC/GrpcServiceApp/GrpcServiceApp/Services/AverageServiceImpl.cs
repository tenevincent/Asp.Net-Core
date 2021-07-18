using Average;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class AverageServiceImpl : AverageService.AverageServiceBase
    {

        private readonly ILogger<AverageServiceImpl> _logger;
        public AverageServiceImpl(ILogger<AverageServiceImpl> logger)
        {
            _logger = logger;
        }

        public override async Task<AverageResponse> ComputeAverage(IAsyncStreamReader<AverageRequest> requestStream, ServerCallContext context)
        {
            int total = 0;
            double result = 0.0;

            while (await requestStream.MoveNext())
            {
                result += requestStream.Current.Number;
                total++;
            }

            return new AverageResponse() { Result = result / total };
        }


    }
}
