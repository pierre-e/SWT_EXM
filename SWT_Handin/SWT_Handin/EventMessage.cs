using System;
using System.Collections.Generic;

namespace SWT_Handin
{
    public class EventMessage
    {
        public readonly Type EventType;
        public readonly List<ITrack> InvolvedTracks;

        public EventMessage(List<ITrack> involvedTracks, Type eventType)
        {
            InvolvedTracks = involvedTracks;
            EventType = eventType;
        }
    }
}