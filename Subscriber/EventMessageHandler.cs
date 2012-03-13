using NServiceBus;
using PublicMessages;
using log4net;

namespace Subscriber
{
    //handles the public event. Can see the ID's 
    public class EventMessageHandler : IHandleMessages<IAmAnEvent>
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof (EventMessageHandler));

        #region IHandleMessages<IAmAnEvent> Members

        public void Handle(IAmAnEvent message)
        {
            Logger.Info(string.Format("Subscriber received Event with Id {0}.", message.Id));
        }

        #endregion
    }
}