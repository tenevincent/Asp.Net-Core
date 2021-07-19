using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Server.Services
{
    public class PrimeNumberService : PrimeNumber.PrimeNumberBase
    {

        private readonly ILogger<PrimeNumberService> _logger;
        public PrimeNumberService(ILogger<PrimeNumberService> logger)
        {
            _logger = logger;
        }


        public override async Task PrimeNumberDecomposition(PrimeNumberDecompositionRequest request, IServerStreamWriter<PrimeNumberDecompositionResponse> responseStream, ServerCallContext context)
        {
            Console.WriteLine("The server received the request :");
            Console.WriteLine(request.ToString());

            int number = request.Number;
            int divisor = 2;

            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    number /= divisor;
                    await responseStream.WriteAsync(new PrimeNumberDecompositionResponse() { PrimeFactor = divisor });
                }
                else
                    divisor++;
            }
        }


    }
}
