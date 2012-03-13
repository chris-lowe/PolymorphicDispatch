using NServiceBus;

namespace Publisher
{
    internal class EndpointConfig : IConfigureThisEndpoint, AsA_Server, AsA_Publisher
    {
    }
}