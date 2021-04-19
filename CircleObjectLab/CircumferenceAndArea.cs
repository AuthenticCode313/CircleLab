using System;
using System.Collections.Generic;
using System.Text;

namespace CircleObjectLab
{
    class CircumferenceAndArea
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public double Circle(double radius)
        {
            this._radius = radius;
            return this._radius;
        }


        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * this._radius;
            return circumference;
               
        }

        public string CalculateFormattedCircumference()
        {
            
            return $"{Math.Round(CalculateCircumference(), 2)}";
        }

        public double CalculateArea()
        {
            double area = Math.PI * this._radius * this._radius;
            return area;

        }

        public string CalculatedFormattedArea()
        {
           
            return $"{Math.Round(CalculateArea(), 2)}";
        }

        private string FormatNumber(double x)
        {
            return $"Circumference: {CalculateFormattedCircumference()} \n Area: {CalculatedFormattedArea()}";
        }
    }
}
