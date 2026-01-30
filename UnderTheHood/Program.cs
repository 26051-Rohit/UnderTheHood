using System;

namespace UnderTheHood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2(3, 7);

            Class1 c1 = new Class1(c2);
            c1.ModifyClass2();

            Class3 c3 = new Class3(c2);
            c3.DoOperations();

            Class2 p = new Class4(5, 6);
            Class4 ch = new Class4(5, 6);

            p.DoOperations();
            ch.DoOperations();

            c2.ShowPoint();
            Console.WriteLine($"{c2.a} {c2.b}");

            c3.MyAnswer();

            p.ShowPoint();
            Console.WriteLine($"{p.a} {p.b}");

            ch.ShowPoint();
            Console.WriteLine($"{ch.a} {ch.b}");
        }
    }
}
