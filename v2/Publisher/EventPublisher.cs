using System;
using InternalEvents;
using NServiceBus;

namespace Publisher
{
    public class EventPublisher : IWantToRunAtStartup
    {
        public IBus Bus { get; set; }

        //Publishes IAmAnInternalEvent

        #region IWantToRunAtStartup Members

        public void Run()
        {
            Console.WriteLine("This will publish IAmAnInternalEvent internally and IAmAnEvent Externally.");
            Console.WriteLine("Press 'Enter' to publish a message.To exit, Ctrl + C");

            while (Console.ReadLine() != null)
            {
                var eventMessage = Bus.CreateInstance<IAmAnInternalEvent>();

                eventMessage.Id = Guid.NewGuid();
                eventMessage.InternalData1 = "internal";
                eventMessage.InternalData2 = "event";
                Bus.Publish(eventMessage);

                Console.WriteLine("Published event with Id {0}.", eventMessage.Id);
            }
        }

        public void Stop()
        {
        }

        #endregion
    }
}