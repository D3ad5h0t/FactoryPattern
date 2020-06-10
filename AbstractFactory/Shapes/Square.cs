using System;

namespace AbstractFactory.Shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Basic square");
        }
    }
}