using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InternalEvents;
using NServiceBus;

namespace Publisher
{
    public class EventPublisher : IWantToRunAtStartup
    {
        public IBus Bus { get; set; }

        //Publishes IAmAnInternalEvent
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
    }

    //Handle IAmAnInternalEvent locally. Can access all the properties
    //doesn't workk if you remove the subscription queue endpoint mapping
    public class HandleInternalEvent : IHandleMessages<IAmAnInternalEvent>
    {
        public void Handle(IAmAnInternalEvent message)
        {
            Console.WriteLine("Handled event with Id {0}.", message.Id);        
        }
    }
}
