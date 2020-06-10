using System;
using AbstractFactory.Shapes;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicCircle = GetFactory(false).Create(Shape.Circle);
            basicCircle.Draw();

            var roundedSquare = GetFactory(true).Create(Shape.Square);
            roundedSquare.Draw();
        }

        public static ShapeFactory GetFactory(bool rounded) => rounded ? (ShapeFactory) new RoundedShapeFactory() : new BasicShapeFactory();
    }
}