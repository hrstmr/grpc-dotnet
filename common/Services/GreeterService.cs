using Grpc.Core;

namespace common.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
    //public override Task<GuessNumberResponse> GuessNumber(GuessNumberRequest request, ServerCallContext context)
    //{
    //    return Task.FromResult(new GuessNumberResponse()
    //    {
    //        Number = 5
    //    });
    //}
}

public class GreetersService : contracts.Class1
{
    private readonly ILogger<GreeterService> _logger;
    public GreetersService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

}
