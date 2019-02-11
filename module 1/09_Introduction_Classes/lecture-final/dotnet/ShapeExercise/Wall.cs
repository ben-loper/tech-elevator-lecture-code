using System;
using System.Collections.Generic;
using System.Text;

namespace PaintJob
{
    public class Wall
    {
        // Member Variable
        private bool _isCircle = false;
        private List<double> _windows = new List<double>();

        // Property
        public double Radius { get; private set; } = 0;
        public double Length { get; private set; } = 0;
        public double Width { get; private set; } = 0;
        public string Location { get; private set; } = "Unknown";

        // Derived Property
        public double Area
        {
            get
            {
                double result = 0;
                if(_isCircle)
                {
                    double area = CalculateArea(Radius);
                    result = SubtractWindowArea(area);
                }
                else
                {
                    double area = CalculateArea(Length, Width);
                    result = SubtractWindowArea(area);
                }
                return result;
            }
        }

        // Constructor
        public Wall(double length, double width, string location)
        {
            Length = length;
            Width = width;
            _isCircle = false;
            Location = location;
        }

        // Overloaded Constructor
        public Wall(double radius, string location)
        {
            Radius = radius;
            _isCircle = true;
            Location = location;
        }

        // Method
        public void AddWindow(double area)
        {
            _windows.Add(area);
        }

        // Method
        private double CalculateArea(double radius)
        {
            const double PI = 3.14;
            return PI * radius * radius;
        }

        // Overloaded Method
        private double CalculateArea(double length, double width)
        {
            return length * width;
        }

        // Method
        private double SubtractWindowArea(double wallArea)
        {
            double totalWindowArea = 0;
            foreach(var windowArea in _windows)
            {
                totalWindowArea += windowArea;
            }
            return wallArea - totalWindowArea;
        }

        // Object Equality (Override Equals method)
        public override bool Equals(object obj)
        {
            var wall = (Wall)obj;
            return wall.Area == Area;
        }

        // Stringification (Override ToString method)
        public override string ToString()
        {
            return $"{Location} Area: {Area}";
        }

    }
}
