///////////////////////////////////////////////////////////
//  TwoDPosition.cs
//  Implementation of the Class TwoDPosition
//  Generated by Enterprise Architect
//  Created on:      18-jun-2014 01:25:56
//  Original author: Pierre
///////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;

namespace SWT_Handin
{
    public class TwoDPosition : IPosition
    {
        private List<Double> _coordinates = new List<double>();

        public TwoDPosition(double x, double y)
        {
            _coordinates.Add(x);
            _coordinates.Add(y);
        }

        public List<Double> Coordinates
        {
            get { return _coordinates; }
            set
            {
                if (value.Count != 2)
                {
                    throw new Exception("This is a 2d track, must have 2 dimensions");
                }
                _coordinates = value;
            }
        }
    } //end TwoDPosition
} //end namespace Implementation