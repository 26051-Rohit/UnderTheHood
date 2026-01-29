using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheHood
{
    public class Class2
    {
        public int a;
        public int b = 4;
        private Point p;

        public Class2(int a = 4, int b = 5)
        {
            this.a = a;
            this.b = b;
            p.x = a + b;
            p.y = a - b;
        }

        public Class2(int b = 5)
        {
            this.a = 2;
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

        public void ShowPoint()
        {
            Console.WriteLine($"Point\n x={p.x}, y={p.y}");
        }
    }
}
