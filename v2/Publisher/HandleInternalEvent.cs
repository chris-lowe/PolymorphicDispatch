using System;
using InternalEvents;
using NServiceBus;

namespace Publisher
{
    //Handle IAmAnInternalEvent locally. Can access all the properties
    //doesn't workk if you remove the subscription queue endpoint mapping
    public class HandleInternalEvent : IHandleMessages<IAmAnInternalEvent>
    {
        #region IHandleMessages<IAmAnInternalEvent> Members

        public void Handle(IAmAnInternalEvent message)
        {
            Console.WriteLine("Handled event with Id {0}.", message.Id);
        }

        #endregion
    }
}