


//2.Создайте базовый класс Shape, который содержит метод GetArea(), возвращающий площадь.

//Создайте два наследуемых класса:

//Circle с полем radius (double) и переопределенным методом GetArea(), который рассчитывает площадь круга (π * радиус²).
//Rectangle с полями width(ширина) и height (double), переопределенным методом GetArea(), который рассчитывает площадь прямоугольника (ширина * высота).
//Создайте объекты обоих классов и вызовите метод GetArea() для каждого объекта.









class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(30);
        Shape restangle = new Restangle(4, 5);


        Console.WriteLine(circle.GetArea());
        Console.WriteLine(restangle.GetArea());


        int a = 5, b = 6;
        int num = Math.Min(a, b);

        Console.WriteLine(num);
    }


    internal abstract class Shape
    {
        public abstract double GetArea();
    }


    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }
    }

    internal class Restangle : Shape
    {
        public double Width { get; set; } // Ширина
        public double Height { get; set; } // Высота


        public Restangle(double width, double height)
        {
            Width = width;
            Height = height;

        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}




