using Grpc.Net.Client;
using GrpcService;
using System;

namespace GrpcClientTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            HelloReply result = client.SayHello(new HelloRequest { Name = "Siddharth" });
            var client2 = new AstraReceiver.AstraReceiverClient(channel);
            AstraReceiverObject result2 = client2.GetAstraReciever(new AstraReceiverRegister
            {
                MessageId = 11017
            });

            Console.WriteLine($"{result.Message}!");
            Console.WriteLine($"{result2.RecieverName}");
            Console.ReadLine();
        }
    }
}
