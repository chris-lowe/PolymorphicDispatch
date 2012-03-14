using System;
using NServiceBus;

namespace PublicMessages
{
    public interface IAmAnEvent : IMessage
    {
        Guid Id { get; set; }
    }
}