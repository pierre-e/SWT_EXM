///////////////////////////////////////////////////////////
//  TwoDTrackFactoryTest.cs
//  Implementation of the Class TwoDTrackFactoryTest
//  Generated by Enterprise Architect
//  Created on:      18-jun-2014 01:26:50
//  Original author: Pierre
///////////////////////////////////////////////////////////


using NUnit.Framework;

namespace SWT_Handin.Tests.Unit
{
    [TestFixture]
    public class TwoDTrackFactoryTest
    {
        [Test]
        public void CreateTrack_CorrectDirection_Valid()
        {
            ITrack track = new TwoDTrackFactory().CreateTrack("test", 80, new TwoDPosition(1, 2), Direction.North);
            Assert.AreEqual(Direction.North, track.TrackDirection);
        }

        [Test]
        public void CreateTrack_CorrectPosition_Valid()
        {
            var pos = new TwoDPosition(1, 2);
            ITrack track = new TwoDTrackFactory().CreateTrack("test", 80, pos, Direction.North);
            Assert.AreEqual(pos, track.Position);
        }

        [Test]
        public void CreateTrack_CorrectSpeed_Valid()
        {
            ITrack track = new TwoDTrackFactory().CreateTrack("test", 80, new TwoDPosition(1, 2), Direction.North);
            Assert.AreEqual(80, track.Speed);
        }

        [Test]
        public void CreateTrack_CorrectTag_Valid()
        {
            ITrack track = new TwoDTrackFactory().CreateTrack("Test", 80, new TwoDPosition(1, 2), Direction.North);
            Assert.AreEqual("Test", track.Tag);
        }
    } //end TwoDTrackFactoryTest
} //end namespace UnitTests