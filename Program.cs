namespace FirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Location location1 = new Location(2, 5);
            Shape shape1 = new Shape(location1);
            Rectangle rectangle = new Rectangle(10, 6);
            Circle circle = new Circle(5);


            shape1.ToString();
            rectangle.ToString();
            circle.ToString();


            Console.WriteLine(rectangle.CountArea());
            Console.WriteLine(circle.CountArea());
            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(circle.Perimeter());
        }
    }
}
