using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Permission.Validation.Models;

namespace Permission.Validation.Default
{
    public class PermissionValidator : IPermissionValidator
    {
        private readonly ILogger _logger;
        
        public PermissionValidator(ILogger<PermissionValidator> logger)
        {
            _logger = logger;
        }
        public Task<PermissionValidationResult> ValidateAsync(HttpContext context)
        {

            _logger.LogDebug("Start permission validation");

            var fail = new PermissionValidationResult
            {
                IsError = true
            };

            return Task.FromResult(fail);
            
        }
    }
}
