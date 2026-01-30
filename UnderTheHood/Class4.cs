using System;

namespace UnderTheHood
{
    internal class Class4 : Class2
    {
        public Class4(int a = 10, int b = 20) : base(a, b)
        {
        }

        public override void DoOperations()
        {
            base.DoOperations();
        }

        public new void ShowPoint()
        {
            Point temp = base.GetPoint();
            Console.WriteLine($"{temp.x} {temp.y}");
        }
    }
}
