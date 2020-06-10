using System;
using AbstractFactory.Shapes;

namespace AbstractFactory
{
    public class BasicShapeFactory : ShapeFactory
    {
        public override IShape Create(Shape shape)
        {
            switch (shape)
            {
                case Shape.Square:
                    return new Square();
                case Shape.Circle:
                    return new Circle();
                default:
                    throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
            }
        }
    }
}