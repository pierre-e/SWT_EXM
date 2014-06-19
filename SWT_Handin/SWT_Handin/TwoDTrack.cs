///////////////////////////////////////////////////////////
//  TwoDTrack.cs
//  Implementation of the Class TwoDTrack
//  Generated by Enterprise Architect
//  Created on:      18-jun-2014 01:25:56
//  Original author: Pierre
///////////////////////////////////////////////////////////


namespace SWT_Handin
{
    public class TwoDTrack : ITrack
    {
        public string Tag { get; set; }
        public int Speed { get; set; }
        public IPosition Position { get; set; }
        public Direction TrackDirection { get; set; }
    } //end TwoDTrack
} //end namespace Implementation