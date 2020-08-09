using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using StandardProxyLib;

namespace GrpcService
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly IStandardMessage standardMessage;

        public GreeterService(ILogger<GreeterService> logger, IStandardMessage standardMessage)
        {
            _logger = logger;
            this.standardMessage = standardMessage;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var message = standardMessage.GetMessage(1);
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name + message
            }) ;
        }
    }
}
