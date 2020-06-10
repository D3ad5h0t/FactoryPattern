using System;
using AbstractFactory.Shapes;

namespace AbstractFactory
{
    public class RoundedShapeFactory : ShapeFactory
    {
        public override IShape Create(Shape shape)
        {
            switch (shape)
            {
                case Shape.Square:
                    return new RoundedSquare();
                case Shape.Circle:
                    return new RoundedCircle();
                default:
                    throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
            }
        }
    }
}