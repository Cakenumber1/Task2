using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Circle
    {
        Point mid= new Point();
        double r;
        public Circle()
        {
            this.mid.SetAll(0, 0);
            this.r = 1;
        }
        public Circle(Point newmid, double R)
        {
            this.mid.SetAll(newmid.GetX(), newmid.GetY());
            this.r = R;
        }
        public void SetAll(double x, double y, double a)
        {
            mid.SetAll(x, y);
            r = a;
        }
        public Point GetCoord()
        {
            return this.mid;
        }
        public double GetX()//test 1.1
        {
            return this.mid.GetX();
        }
        public double GetY()//test 1.1
        {
            return this.mid.GetY();
        }
        public double GetRad()// test 1.2
        {
            return this.r;
        }
        public double GetS()//test 2.1
        {
            return 3.14 * r * r;
        }
        public double GetP()//test 2.2
        {
            return 2 * 3.14 * r;
        }
        public void PrintAll()
        {
            Console.WriteLine($"X: {GetCoord().GetX()}  Y: {GetCoord().GetY()}  r: {GetRad()}");
        }
        public void MoveOnV(Point midchange)//test 3
        {
            mid.SetX(mid.GetX() + midchange.GetX());
            mid.SetY(mid.GetY() + midchange.GetY());
            //mid.SetAll(mid.GetX() + midchange.GetX(), mid.GetY() + midchange.GetY());
        }

    }
}

