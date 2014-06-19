///////////////////////////////////////////////////////////
//  EventNearMiss.cs
//  Implementation of the Class EventNearMiss
//  Generated by Enterprise Architect
//  Created on:      18-jun-2014 01:26:32
//  Original author: Pierre
///////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;

namespace SWT_Handin.EventHandling
{
    public class EventNearMiss : IEvent
    {
        private ATC _atc;
        public void HookToDetector()
        {
            EventHandler.EventList.Add(this);
        }

        public void AttachToAtc(ref ATC airTrafficControl)
        {
            _atc = airTrafficControl;
        }

        public bool CheckEventConditions(List<ITrack> tracks)
        {
            var nearMissList = new List<Tuple<ITrack, ITrack>>();
            foreach (var track1 in tracks)
            {
                foreach (var track2 in tracks)
                {
                    if (track2 == track1)
                        continue;
                    double distanceBetweenTracks = DistanceBetweenTracks(track1, track2);
                    if (distanceBetweenTracks < _atc.NearMissDist && distanceBetweenTracks > _atc.CollisionDist)
                    {
                        nearMissList.Add(new Tuple<ITrack,ITrack>(track1, track2));
                    }
                }
            }
            return (nearMissList.Count != 0);
        }

        private double DistanceBetweenTracks(ITrack track1, ITrack track2)
        {
            if(track1.Position.Coordinates.Count != track2.Position.Coordinates.Count)
                throw new Exception("Tracks must have same dimensions");
            double distanceSquared = track1.Position.Coordinates.Select((t, i) => Math.Pow(t - track2.Position.Coordinates[i], 2)).Sum();
            return Math.Sqrt(distanceSquared);
        }
    }
} //end EventNearMiss