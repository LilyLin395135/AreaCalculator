using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Room
    {
        private string _unit;
        private double _area;
        double conversionRate = 0.09290304;

        public Room(double length, double width, string unit)
        {
            _unit = unit;
            _area = length* width;
        }

        public double GetMeter
        {
            get
            {
                if (IsMeter()==false)
                {
                    _area*= conversionRate;
                }
                return _area;
            }
        }

        public double GetFeet
        {
            get
            {
                if(IsFeet()==false)
                {
                    _area /= conversionRate;
                }
                return _area;
            }
        }

        public bool IsMeter()
        {
            if (_unit == UnitOfArea.Meters.ToString().ToLower()) return true;
            return false;
        }

        public bool IsFeet()
        {
            if (_unit == UnitOfArea.Feet.ToString().ToLower()) return true;
            return false;
        }

        //下面這種巢狀迴圈太多層了，很難馬上知道作用。
        //重構：先將會跑出wrongMassage的先寫出來。這部分會在與user的互動那邊，因為是user輸入錯誤，而不是物件本身的行為。
        //public double Transfer(double area)
        //{
        //    double resultLength, resultWidth;
        //    if (double.TryParse(length, out resultLength))
        //    {                
        //        if (double.TryParse(width, out resultWidth))
        //        {
        //            Console.WriteLine($"You entered dimensions of {length} {Unit} by {width} {Unit}.");
        //            double area = resultLength * resultWidth;
        //            double transferArea = area * _unitAndNumber[Unit];
        //            Console.WriteLine($"The area is \n{area} square {Unit} \n{transferArea} square meters");//最後這個單位不知道怎麼樣才能叫出另外一個
        //        }
        //        else
        //        {
        //            Console.WriteLine(wrongMessage);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(wrongMessage);
        //    }
        //    return 0;
        //}

    }
    
}
