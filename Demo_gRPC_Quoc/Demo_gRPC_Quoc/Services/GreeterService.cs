using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_gRPC_Quoc
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<SumReply> Sum(SumRequest request, ServerCallContext context)
        {
            return Task.FromResult(new SumReply
            {
                Result = request.Number1 + request.Number2
            }) ;
        }
        public override Task<SubReply>Sub(SubRequest request,ServerCallContext context)
        {
            return Task.FromResult(new SubReply
            {
                Result = request.Number1 - request.Number2
            });
        }

        public override Task<MulReply> Mul(MulRequest request, ServerCallContext context)
        {
            return Task.FromResult(new MulReply
            {
                Result = request.Number1 * request.Number2
            });
        }
        public override Task<DivReply> Div(DivRequest request, ServerCallContext context)
        {
            return Task.FromResult(new DivReply
            {
                Result = (float)request.Number1 / request.Number2
            });
        }
    }
}
