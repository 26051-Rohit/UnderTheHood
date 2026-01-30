using System;

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
            Console.WriteLine($"{c2.a} {c2.b}");
        }
    }
}
