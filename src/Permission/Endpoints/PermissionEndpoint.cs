using System;
using Permission.Hosting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Permission.Validation;
using Microsoft.Extensions.Logging;

namespace Permission.Endpoints
{
    public class PermissionEndpoint : IEndpointHandler
    {
        private readonly IPermissionValidator _permissionValidator;
        private readonly ILogger _logger;

        public PermissionEndpoint(IPermissionValidator permissionValidator, ILogger<PermissionEndpoint> logger)
        {
            _permissionValidator = permissionValidator;
            _logger = logger;
        }
        public async Task<IEndpointResult> ProcessAsync(HttpContext context)
        {
            _logger.LogDebug("Start userinfo request");

            // userinfo requires an access token on the request
            var permissionResult = await _permissionValidator.ValidateAsync(context);
            return null;
        }
    }
}
