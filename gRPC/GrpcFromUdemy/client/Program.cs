using Average;
using Grpc.Core;
using Grpc.Net.Client;
using Max;
using Server.Services;
using Sqrt;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
 
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


namespace Client
{
    class Program
    {

        const string target = "127.0.0.1:50051";
        private static GrpcChannel _channel;
        private static Greeter.GreeterClient _client;

        static async Task Main(string[] args)
        {
            _channel = GrpcChannel.ForAddress("https://localhost:5001");
            _client = new Greeter.GreeterClient(_channel);

            var response = await _client.SayHelloAsync(
                new HelloRequest { Greeting = new Greeting() { FirstName = "Tene", LastName = "Vincent" } });

            Console.WriteLine(response.Result);
            //await CalculatorStreamAsync(channel);

            //await CallManyGreetingAsync();

            //await PrimeNumbergRPCCallAsync();

            //await DoLongGreet();

            //await DoGreetEveryone();

            //await DoAverageCalculationAsync();

            //await BidirectionalCommunicationAync();

            //await BidirectionalExerciseDemoAsync();

            await ExceptionDemoWithgRPCAsync();


            _channel.ShutdownAsync().Wait();
            Console.ReadKey();
            Console.WriteLine("Hello World!");


            //var clientcert = File.ReadAllText("ssl/client.crt");
            //var clientkey = File.ReadAllText("ssl/client.key");
            //var cacert = File.ReadAllText("ssl/ca.crt");
            //var channelCredentials = new SslCredentials(cacert, new KeyCertificatePair(clientcert, clientkey));
            //Channel channel = new Channel("localhost", 50051, channelCredentials);




        }

        private static async Task ExceptionDemoWithgRPCAsync()
        {
            var client = new Sqrt.SqrtService.SqrtServiceClient(_channel);

            int number = -1;

            try
            {
                var response = await client.SqrtCalculateAsync(new SqrtRequest() { Number = number },
                                            deadline: DateTime.UtcNow.AddSeconds(5));

                Console.WriteLine(response.SquareRoot);
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.InvalidArgument)
            {
                Console.WriteLine("Error : " + e.Status.Detail);
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.DeadlineExceeded)
            {
                Console.WriteLine("Deadline exceeded !");
            }


        }

        private static async Task BidirectionalExerciseDemoAsync()
        {
            var client = new Max.FindMax.FindMaxClient(_channel);
            var stream = client.FindMaximum();

            var responseReaderTask = Task.Run(async () =>
            {
                while (await stream.ResponseStream.MoveNext())
                    Console.WriteLine(stream.ResponseStream.Current.Max);
            });

            int[] numbers = { 1, 5, 3, 6, 2, 20 };

            foreach (var number in numbers)
            {
                await stream.RequestStream.WriteAsync(new FindMaxRequest() { Number = number });
            }

            await stream.RequestStream.CompleteAsync();
            await responseReaderTask;
        }

        private static async Task BidirectionalCommunicationAync()
        {
            var client = new Greeter.GreeterClient(_channel);
            var stream = client.GreetEveryoneBidirectional();



            var responseReaderTask = Task.Run(async () =>
            {
                while (await stream.ResponseStream.MoveNext())
                {
                    Console.WriteLine("Received : " + stream.ResponseStream.Current.Result);
                }
            });

            Greeting[] greetings =
            {
                new Greeting() { FirstName = "John", LastName = "Doe" },
                new Greeting() { FirstName = "Clement", LastName = "Jean" },
                new Greeting() { FirstName = "Patricia", LastName = "Hertz" }
            };

            foreach (var greeting in greetings)
            {
                Console.WriteLine("Sending : " + greeting.ToString());
                await stream.RequestStream.WriteAsync(new GreetEveryoneRequest()
                {
                    Greeting = greeting
                });
            }

            await stream.RequestStream.CompleteAsync();
            await responseReaderTask;
        }

        private static async Task DoAverageCalculationAsync()
        {
            var client = new AverageService.AverageServiceClient(_channel);
            var stream = client.ComputeAverage();

            foreach (int number in Enumerable.Range(1, 40))
            {
                var request = new AverageRequest() { Number = number };

                await stream.RequestStream.WriteAsync(request);
            }

            await stream.RequestStream.CompleteAsync();

          

            var response = await stream.ResponseAsync;

            Console.WriteLine(response.Result);
        }

        private static async Task PrimeNumbergRPCCallAsync()
        {


            var client = new PrimeNumber.PrimeNumberClient(_channel);

            var request = new PrimeNumberDecompositionRequest()
            {
                Number = 200
            };

            var response = client.PrimeNumberDecomposition(request);

            while (await response.ResponseStream.MoveNext())
            {
                Console.WriteLine(response.ResponseStream.Current.PrimeFactor);
                await Task.Delay(200);
            }

        }

        private static async Task CallManyGreetingAsync()
        {

            var client = new Greeter.GreeterClient(_channel);


            var greeting = new Greeting() { FirstName = "Tene", LastName = "Vincent" };
            var request = new GreetManyTimesRequest() { Greeting = greeting };

            var response = client.GreetManyTimesServerStreaming(request);
            while (await response.ResponseStream.MoveNext())
            {
                Console.WriteLine(response.ResponseStream.Current.Result
                   + " at " + response.ResponseStream.Current.Time.ToString());
                await Task.Delay(200);
            }

        }

        private static async Task CalculatorStreamAsync(GrpcChannel channel)
        {
            var clientSun = new Calculator.CalculatorClient(channel);
            var resultSum = await clientSun.CalculateAsync(new ParamsRequest() { FirstNumber = 10, SecondNumber = 15 });
            Console.WriteLine("Result sum is " + resultSum.Sum);
        }


        public static async Task DoLongGreet()
        {


            var client = new Greeter.GreeterClient(_channel);
            var greeting = new Greeting()
            {
                FirstName = "Clement",
                LastName = "Jean"
            };

            var request = new LongGreetRequest() { Greeting = greeting };
            var stream = client.LongGreetClientStreaming();

            foreach (int i in Enumerable.Range(1, 10))
            {
                await stream.RequestStream.WriteAsync(request);
            }

            await stream.RequestStream.CompleteAsync();

            var response = await stream.ResponseAsync;

            Console.WriteLine("Server response is " + response.Result);
        }
        public static async Task DoGreetEveryone()
        {

            var client = new Greeter.GreeterClient(_channel);

            var stream = client.GreetEveryoneBidirectional();

            var responseReaderTask = Task.Run(async () =>
            {
                while (await stream.ResponseStream.MoveNext())
                {
                    Console.WriteLine("Received : " + stream.ResponseStream.Current.Result);
                }
            });

            Greeting[] greetings =
            {
                new Greeting() { FirstName = "John", LastName = "Doe" },
                new Greeting() { FirstName = "Clement", LastName = "Jean" },
                new Greeting() { FirstName = "Patricia", LastName = "Hertz" }
            };

            foreach (var greeting in greetings)
            {
                Console.WriteLine("Sending : " + greeting.ToString());
                await stream.RequestStream.WriteAsync(new GreetEveryoneRequest()
                {
                    Greeting = greeting
                });
            }

            await stream.RequestStream.CompleteAsync();
            await responseReaderTask;
        }


    }
}
