using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using NServiceBus;
using PublicMessages;

namespace Subscriber
{
    //handles the public event. Can see the ID's 
    public class EventMessageHandler : IHandleMessages<IAmAnEvent>
    {
        public void Handle(IAmAnEvent message)
        {
            Logger.Info(string.Format("Subscriber received Event with Id {0}.", message.Id));
        }

        private static readonly ILog Logger = LogManager.GetLogger(typeof(EventMessageHandler));
    }
}
