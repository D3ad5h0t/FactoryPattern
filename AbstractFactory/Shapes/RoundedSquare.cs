using System;

namespace AbstractFactory.Shapes
{
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rounded square");
        }
    }
}