using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheHood
{
    internal class Class3 : Class2
    {
        public int a;
        public int b;
        public Class1 c1;
        public Point two;

        public Class3(Class2 c2) : base()
        {
            c1 = new Class1(c2);
            two = base.GetPoint();
        }

        public override void DoOperations()
        {
            base.DoOperations();
            two.x *= 2;
            two.y *= 2;
        }
    }
}
