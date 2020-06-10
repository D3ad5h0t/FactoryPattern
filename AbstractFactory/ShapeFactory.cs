using AbstractFactory.Shapes;

namespace AbstractFactory
{
    public abstract class ShapeFactory
    {
        public abstract IShape Create(Shape shape);
    }
}