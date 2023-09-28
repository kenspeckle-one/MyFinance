public class TestEndpoint: Endpoint<Request, Response>
{
    public override void Configure()
    {
        Post("/api/test");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        await SendAsync(new Response()
        {
            Message = "Hello",
        });
    }
}