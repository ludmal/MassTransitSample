using MassTransit;
using MassTransitSample.Cotnracts;

namespace MassTransitSample.Consumers;

public class HelloWorldConsumer : IConsumer<Hello>
{
    private readonly ILogger<HelloWorldConsumer> _logger;

    public HelloWorldConsumer(ILogger<HelloWorldConsumer> logger )
    {
        _logger = logger;
    }
    public Task Consume(ConsumeContext<Hello> context)
    {
        _logger.LogInformation("Consumed message {@Message}", context.Message);
        return Task.CompletedTask;
    }
}