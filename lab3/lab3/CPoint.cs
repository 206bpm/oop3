using System;
namespace lab3
{
    public class CPoint : CGraphicsObject
    {
        public static int a;
        public CPoint(int SideA1)
        {
            SideA = SideA1;
        }
        public int SideA
        {
            get { return a; }
            set { a = value < 0 ? -value : value; }
        }
        public override string Length()
        {
            return (a * 8).ToString();
        }
        public static void Method()
        {
            Console.WriteLine("Enter side length: ");
            a = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
