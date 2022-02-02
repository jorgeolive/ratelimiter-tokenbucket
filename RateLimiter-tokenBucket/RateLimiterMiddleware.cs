namespace RateLimiter_tokenBucket
{
    public class RateLimiterMiddleware
    {
        private readonly RequestDelegate _next;

        public RateLimiterMiddleware(RequestDelegate requestDelegate)
        {
            _next = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context, TokenBucket bucket)
        {
            try
            {
                bucket.UseToken();
                await _next(context);
            }
            catch (NoTokensAvailableException)
            {
                context.Response.StatusCode = 503;
            }
        }
    }
}
