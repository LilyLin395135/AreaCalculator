using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Room
    {
        private double _length;
        private double _width;
        private string _unit;
        public Room(double length, double width, string unit)
        {
            _length = length;
            _width = width;
            _unit = unit;
        }
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        string wrongMessage= "You must input numbers! You bad bad!>A<";
        private readonly Dictionary<string, double> _unitAndNumber = new()
        {
            { "feet", 0.09290304 },
            { "meters", (1/0.09290304) },
        };

        public bool MustFeetOrMeters(string Unit)
        {
            if (_unitAndNumber.ContainsKey(Unit))             
            {
                return true;
            }           
            Console.WriteLine(wrongMessage);
            return false;
        }
        public double IfLengthWidthIsNumberCalculateArea(string length, string width)
        {
            double resultLength, resultWidth;
            if (double.TryParse(length, out resultLength))
            {                
                if (double.TryParse(width, out resultWidth))
                {
                    Console.WriteLine($"You entered dimensions of {length} {Unit} by {width} {Unit}.");
                    double area = resultLength * resultWidth;
                    double transferArea = area * _unitAndNumber[Unit];
                    Console.WriteLine($"The area is \n{area} square {Unit} \n{transferArea} square meters");//最後這個單位不知道怎麼樣才能叫出另外一個
                }
                else
                {
                    Console.WriteLine(wrongMessage);
                }
            }
            else
            {
                Console.WriteLine(wrongMessage);
            }
            return 0;
        }

    }
    
}
