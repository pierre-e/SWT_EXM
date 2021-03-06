///////////////////////////////////////////////////////////
//  ITrack.cs
//  Implementation of the Interface ITrack
//  Generated by Enterprise Architect
//  Created on:      18-jun-2014 01:25:57
//  Original author: Pierre
///////////////////////////////////////////////////////////


using System;

namespace SWT_Handin
{
    public interface ITrack
    {
        Direction TrackDirection { get; set; }
        int Speed { get; set; }
        IPosition Position { get; set; }
        String Tag { get; set; }

        void Tick(int tickTime);

    } //end ITrack
} //end namespace Implementation