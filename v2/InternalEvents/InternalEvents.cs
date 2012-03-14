using PublicMessages;

namespace InternalEvents
{
    public interface IAmAnInternalEvent : IAmAnEvent
    {
        string InternalData1 { get; set; }
        string InternalData2 { get; set; }
    }
}