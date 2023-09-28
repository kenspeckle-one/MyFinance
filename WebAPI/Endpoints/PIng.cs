public class Ping: EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/api/ping");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendAsync(new());
    }
}