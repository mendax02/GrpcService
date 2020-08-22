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

            // var channel1 = new System.Threading.Channels.Channel("", Grpc.Core.ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);
            HelloReply result = client.SayHello(new HelloRequest { Name = "Siddharth" });
            var client2 = new AstraReceiver.AstraReceiverClient(channel);
            AstraReceiverObject result2 = client2.GetAstraReciever(new AstraReceiverRegister
            {
                MessageId = 11017
            });
            //  channel.ShutdownAsync().Wait();

            Console.WriteLine($"{result.Message}!");
            Console.WriteLine($"{result2.RecieverName}");
            Console.ReadLine();
        }
    }
}
