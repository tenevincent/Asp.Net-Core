using Grpc.Core;
using Max;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Server.Services
{
    public class FindMaxServiceImpl : Max.FindMax.FindMaxBase
    {
        private readonly ILogger<FindMaxServiceImpl> _logger;
        public FindMaxServiceImpl(ILogger<FindMaxServiceImpl> logger)
        {
            _logger = logger;
        }

      

        public override async  Task FindMaximum(IAsyncStreamReader<FindMaxRequest> requestStream, IServerStreamWriter<FindMaxResponse> responseStream, ServerCallContext context)
        {
            int? max = null;

            while (await requestStream.MoveNext())
            {
                if (max == null || max < requestStream.Current.Number)
                {
                    max = requestStream.Current.Number;
                    await responseStream.WriteAsync(new FindMaxResponse() { Max = max.Value });
                }
            }
        }



    }
}
