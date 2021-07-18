using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServiceApp.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloResponse> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloResponse
            {
                Result = "Hello " + request.Greeting.FirstName + " " + request.Greeting.LastName
            }) ;
        }

        public override async Task GreetManyTimesServerStreaming(GreetManyTimesRequest request, IServerStreamWriter<GreetManyTimesResponse> responseStream, ServerCallContext context)
        {

            Console.WriteLine("The server received the request: ");
            Console.WriteLine(request.ToString());

            string result = string.Format("Hello {0} {1}", request.Greeting.FirstName, request.Greeting.LastName);

            foreach (int index in Enumerable.Range(1,20))
            {
                await responseStream.WriteAsync(new GreetManyTimesResponse() {Result = result, Time = Timestamp.FromDateTime(DateTime.UtcNow) });
            }
        }


        public override async Task<LongGreetResponse> LongGreetClientStreaming(IAsyncStreamReader<LongGreetRequest> requestStream, ServerCallContext context)
        {
            string result = "";

            while (await requestStream.MoveNext())
            {
                result += String.Format("Hello {0} {1} {2}",
                    requestStream.Current.Greeting.FirstName,
                    requestStream.Current.Greeting.LastName,
                    Environment.NewLine);
            }

            return new LongGreetResponse() { Result = result };


        }

        public override async Task GreetEveryoneBidirectional(IAsyncStreamReader<GreetEveryoneRequest> requestStream, IServerStreamWriter<GreetEveryoneResponse> responseStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext())
            {
                var result = String.Format("Hello {0} {1}",
                                            requestStream.Current.Greeting.FirstName,
                                            requestStream.Current.Greeting.LastName);

                Console.WriteLine("Sending : " + result);
                await responseStream.WriteAsync(new GreetEveryoneResponse() { Result = result });
            }
        }


    


    


    }
}
