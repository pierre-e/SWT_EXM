///////////////////////////////////////////////////////////
//  TwoDTrackFactory.cs
//  Implementation of the Class TwoDTrackFactory
//  Generated by Enterprise Architect
//  Created on:      18-jun-2014 01:25:56
//  Original author: Pierre
///////////////////////////////////////////////////////////


namespace SWT_Handin
{
    public class TwoDTrackFactory : ITrackFactor
    {
        /// <param name="tag"></param>
        /// <param name="speed"></param>
        /// <param name="pos"></param>
        /// <param name="direction"></param>
        public ITrack CreateTrack(string tag, int speed, IPosition pos, Direction direction)
        {
            return new TwoDTrack {Tag = tag, Speed = speed, Position = pos, TrackDirection = direction};
        }
    } //end TwoDTrackFactory
} //end namespace Implementation