using Microsoft.AspNetCore.Http;

namespace Permission.Hosting
{
    public interface IEndpointRouter
    {
        IEndpointHandler Find(HttpContext context);
    }

}
