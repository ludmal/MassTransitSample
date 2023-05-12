using MassTransit;
using MassTransitSample.Cotnracts;

namespace MassTransitSample.Endpoints;

public static class HelloWorldEndpoint
{
    public static async Task<IResult> Hello(HttpContext context, IBus bus)
    {
        await bus.Publish<Hello>(new Hello()
        {
            Name = "Ludmal De silva"
        });
        return Results.Ok();
    }
}