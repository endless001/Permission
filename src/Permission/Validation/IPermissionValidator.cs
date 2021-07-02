using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Permission.Validation.Models;

namespace Permission.Validation
{
    public interface  IPermissionValidator
    {
        Task<PermissionValidationResult> ValidateAsync(HttpContext context);
    }
}
