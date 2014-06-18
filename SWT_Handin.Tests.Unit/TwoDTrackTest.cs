///////////////////////////////////////////////////////////
//  TwoDTrackTest.cs
//  Implementation of the Class TwoDTrackTest
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
    public class TwoDTrackTest
    {
        [Test]
        public void PropertySpeed_SetAndGet_True()
        {
            TwoDTrack testTrack = new TwoDTrack();
            testTrack.Speed = 100;
            Assert.AreEqual(100, testTrack.Speed);
        }

        public void PropertyTag_SetAndGet_True()
        {
            TwoDTrack testTrack = new TwoDTrack();
            testTrack.Tag = "TestTag!";
            Assert.AreEqual("TestTag!", testTrack.Tag);
        }

        public void PropertyPosition_SetAndGet_True()
        {
            var position = Substitute.For<TwoDPosition>();
            var coordinates = new List<double>();
            coordinates.Add(20.345);
            coordinates.Add(70.234);
            position.Coordinates.Returns(coordinates);

            var testTrack = new TwoDTrack();
            testTrack.Position = position;
            Assert.AreEqual(coordinates, testTrack.Position);
        }
    } //end TwoDTrackTest
} //end namespace UnitTests