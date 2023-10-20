namespace BookHub.Middleware;

public class RequestAuthMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestAuthMiddleware> _logger;

    public RequestAuthMiddleware(RequestDelegate next, ILogger<RequestAuthMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }
    
    public async Task Invoke(HttpContext context)
    {

        var InitialPass = "IBetYouCanNotGuessThisOne";
        
        var token = context.Request.Headers["Authorization"];

        if (!token.Equals(InitialPass))
        {
            await context.Response.WriteAsync("Unauthorized");
        }

        else
        {
            await _next(context);
        }

        _logger.LogInformation($"Request token is {token}");
    }
}