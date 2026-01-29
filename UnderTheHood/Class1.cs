using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheHood
{
    public class Class1
    {
        private Class2 c2;
        public int a = 3;
        public int b;

        public Class1(Class2 c2)
        {
            this.c2 = c2;
        }

        public void ModifyClass2()
        {
            c2.a += 10;
            c2.b += 10;
        }

        public void ShowClass2()
        {
            Console.WriteLine($"a={c2.a}, b={c2.b}");
        }
    }
}
