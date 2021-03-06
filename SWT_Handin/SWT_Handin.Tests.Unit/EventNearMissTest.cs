///////////////////////////////////////////////////////////
//  EventNearMissTest.cs
//  Implementation of the Class EventNearMissTest
//  Generated by Enterprise Architect
//  Created on:      18-jun-2014 01:26:50
//  Original author: Pierre
///////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;

namespace SWT_Handin.Tests.Unit
{
    [TestFixture]
    public class EventNearMissTest
    {
        public void HookToDetector_Succes()
        {
            var myHappening = new EventAtDestination();
            var eventSub = Substitute.For<EventHandler>();
            EventHandler.EventList = new List<IEvent>();
            myHappening.HookToDetector();
            Assert.True(EventHandler.EventList[EventHandler.EventList.Count - 1] is EventAtDestination);
        }

        [Test]
        public void CheckEventCond_Valid()
        {
            var atc = Substitute.For<ATC>();
            ITrack t1 = new TwoDTrackFactory().CreateTrack("Test", 80, new TwoDPosition(50, 50), Direction.East);
            ITrack t2 = new TwoDTrackFactory().CreateTrack("Test", 80, new TwoDPosition(2500, 50), Direction.East);
            var tracklist = new List<ITrack> {t1, t2};
            var myHappening = new EventNearMiss();
            myHappening.AttachToAtc(atc);
            List<EventMessage> check = myHappening.CheckEventConditionsAndHandle(tracklist);
            Assert.True(check.Count > 0);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CheckEventCond_Invalid()
        {
            var atc = Substitute.For<ATC>();
            var posSub1 = Substitute.For<IPosition>();
            posSub1.Coordinates = new List<double>{0,100,500};
            var posSub2 = Substitute.For<IPosition>();
            posSub2.Coordinates = new List<double>{0,100};

            ITrack t1 = new TwoDTrackFactory().CreateTrack("Test", 80, posSub1, Direction.East);
            ITrack t2 = new TwoDTrackFactory().CreateTrack("Test", 80, posSub2, Direction.East);
            var tracklist = new List<ITrack> { t1, t2 };
            var myHappening = new EventNearMiss();
            myHappening.AttachToAtc(atc);
            List<EventMessage> check = myHappening.CheckEventConditionsAndHandle(tracklist);
        }

    } //end EventNearMissTest
} //end namespace UnitTests