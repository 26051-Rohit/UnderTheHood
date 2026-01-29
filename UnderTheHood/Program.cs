namespace UnderTheHood
{
    public struct Point
    {
        public int x;
        public int y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2(10, 20);
            c2.ShowPoint();

            // Pass Class2 into Class1 (reference type)
            Class1 c1 = new Class1(c2);
            c1.ShowClass2();

            Console.WriteLine("Modifying Class2 via Class1 (reference type)...");
            c1.ModifyClass2();
            c1.ShowClass2(); // global modification visible

            // Demonstrate struct behavior
            Class4 c4 = new Class4(c2);
            Point pOriginal = c2.GetPoint();
            Console.WriteLine($"Original struct -> x={pOriginal.x}, y={pOriginal.y}");

            c4.ModifyStruct(pOriginal); // modifies copy, not original

            Point pAfter = c2.GetPoint();
            Console.WriteLine($"Struct after modification attempt -> x={pAfter.x}, y={pAfter.y}");

            Console.ReadLine();
        }
    }
}
