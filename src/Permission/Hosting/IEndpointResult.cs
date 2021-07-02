using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Permission.Hosting
{
    public interface IEndpointResult
    {
        Task ExecuteAsync(HttpContext context);
    }
}
