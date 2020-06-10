using System;

namespace AbstractFactory.Shapes
{
    public class RoundedCircle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rounded circle");
        }
    }
}