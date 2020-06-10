using System;

namespace AbstractFactory.Shapes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Basic circle");
        }
    }
}