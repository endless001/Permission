using Permission.Constants;
using Permission.Hosting;
using Permission.Options;


namespace Permission.Extensions
{
    public static class EndpointOptionsExtensions
    {
        public static bool IsEndpointEnabled(this EndpointsOptions options, Endpoint endpoint)
        {
            return endpoint?.Name switch
            {
                EndpointNames.Permission => options.EnablePermissionEndpoint,
                _ => true
            };
        }
    }
}
