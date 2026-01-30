using System;

namespace UnderTheHood
{
    public class Class2
    {
        public int a;
        public int b;
        private Point p;

        public Class2(int a = 4, int b = 5)
        {
            this.a = a;
            this.b = b;

            p.x = a + b;
            p.y = a - b;
        }

        public virtual void DoOperations()
        {
            p.x += a;
            p.y += b;
        }

        public Point GetPoint()
        {
            return p;
        }

        public void SetPoint(Point newPoint)
        {
            p = newPoint;
        }

        public virtual void ShowPoint()
        {
            Console.WriteLine($"{p.x} {p.y}");
        }
    }
}
