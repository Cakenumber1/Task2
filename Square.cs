using System;


namespace Task2
{
    class Square
    {
        Point leftLower = new Point();
        Point rightTop = new Point();
        public Square(Point a, Point b)
        {
            leftLower = a;
            rightTop = b;
        }
        public double getR()
        {
            return (rightTop.GetX() - leftLower.GetX()) * 4;
        }
        public double getS()
        {
           return  (rightTop.GetX() - leftLower.GetX()) * (rightTop.GetY() - leftLower.GetY());
        }
        public void PrintAll()
        {
            Console.WriteLine($"A: {rightTop.GetX()} {rightTop.GetY()}  B: {rightTop.GetX()} {leftLower.GetY()}  C: {leftLower.GetX()} {leftLower.GetY()} D: {leftLower.GetX()} {rightTop.GetY()}");
        }
        public void MoveOnV(Point change)
        {
            leftLower.SetAll(leftLower.GetX()+change.GetX(), leftLower.GetY() + change.GetY());
            leftLower.SetAll(rightTop.GetX() + change.GetX(), rightTop.GetY() + change.GetY());
        }
    }
}
