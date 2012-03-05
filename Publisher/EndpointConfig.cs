using NServiceBus;

namespace Publisher
{
    class EndpointConfig : IConfigureThisEndpoint, AsA_Server, AsA_Publisher { }
}
