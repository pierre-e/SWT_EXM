using System;

namespace SWT_Handin
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testAtc = new ATC();
            var track1 = new TwoDTrackFactory().CreateTrack("Track one", 250, new TwoDPosition(250, 99000), Direction.South);
            testAtc.AcceptIncomingTrack(track1);
            Console.ReadLine();
        }
    }
}