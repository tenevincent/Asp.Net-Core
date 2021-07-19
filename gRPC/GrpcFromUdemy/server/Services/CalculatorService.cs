
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services
{
    public class CalculatorService : Calculator.CalculatorBase
    {
        private readonly ILogger<CalculatorService> _logger;
        public CalculatorService(ILogger<CalculatorService> logger)
        {
            _logger = logger;
        }

        public override Task<ResultResponse> Calculate(ParamsRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ResultResponse
            {
                 Sum = request.FirstNumber + request.SecondNumber
            }) ;
        }
    }
}
