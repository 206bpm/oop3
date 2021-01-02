using System;
namespace lab3
{
    public class Class1 : CPoint
    {
        public Class1(int SideA1) : base(SideA1)
        {
            throw new System.NotImplementedException();
        }
        ~Class1()
        {
            throw new System.NotImplementedException();
        }
        public static void function()
        {
            CPoint.Method();
            CGraphicsObject figure = new CPoint(CPoint.a);
            figure.Info();
        }
    }
}
