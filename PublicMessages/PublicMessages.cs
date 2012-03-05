using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace PublicMessages
{
    public interface IAmAnEvent : IMessage
    {
        Guid Id { get; set; }
    }
}