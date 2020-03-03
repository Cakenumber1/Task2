using System;

namespace Task2
{
     public class Point
    {
        double _x;
        double _y;
        public Point()
        {
            this._x = 0;
            this._y = 0;
        }
        public Point(double a, double b)
        {
            this._x = a;
            this._y = b;
        }
        public void SetX(double a)
        {
            this._x = a;
        }
        public void SetY(double a)
        {
            this._y = a;
        }
        public double GetX()
        {
            return _x;
        }
        public double GetY()
        {
            return _y;
        }
        public void SetAll(double a1, double a2)
        {
            _x = a1;
            _y = a2;
        }
    }
}
