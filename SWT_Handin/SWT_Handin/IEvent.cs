using System.Collections.Generic;

namespace SWT_Handin
{
    public interface IEvent
    {
        void HookToDetector();
        void AttachToAtc(ref ATC airTrafficControl);
        List<EventMessage> CheckEventConditions(List<ITrack> tracks);
    }
}