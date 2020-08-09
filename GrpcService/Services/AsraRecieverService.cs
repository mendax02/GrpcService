using Google.Protobuf;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using StandardProxyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class AstraRecieverService : AstraReceiver.AstraReceiverBase, IAstraReciever
    {
        private readonly ILogger<AstraRecieverService> logger;
        private readonly IStandardMessage standardMessage;

        public AstraRecieverService(ILogger<AstraRecieverService> logger, IStandardMessage standardMessage)
        {
            this.logger = logger;
            this.standardMessage = standardMessage;
        }

        public override Task<AstraReceiverObject> GetAstraReciever(AstraReceiverRegister request, ServerCallContext context)
        {
            return Task.FromResult(new AstraReceiverObject
            {
                RecieverName = standardMessage.GetMessage(request.MessageId)
            });
        }
    }
}
