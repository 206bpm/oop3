using System;
namespace lab3
{
    public abstract class CGraphicsObject
    {
        public abstract string Length();
        public void Info()
        {
            Console.WriteLine($"Perimeter of the octagon: {Length()}\n");
        }
    }
}
