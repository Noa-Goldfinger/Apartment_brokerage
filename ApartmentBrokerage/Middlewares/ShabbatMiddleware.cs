namespace Solid.API.Middlewares
{
    public class ShabbatMiddleware
    {
        readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var date = DateTime.Now;
            if(date.DayOfWeek == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            else await _next(context);
        }
    }
}
