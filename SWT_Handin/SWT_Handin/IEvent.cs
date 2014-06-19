using System.Collections.Generic;

namespace SWT_Handin
{
    public interface IEvent
    {
        void HookToDetector();
        void AttachToAtc(ATC airTrafficControl);
        List<EventMessage> CheckEventConditionsAndHandle(List<ITrack> tracks);
    }
}