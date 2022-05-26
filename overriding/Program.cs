namespace consoleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello People!!!!");
            Shape[] shapes={new Rectangle(10,12), new Square(12), new Cirle(5)};
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape}:Area:{Shape.GetArea(shape)}; "+$"Perimeter:{Shape.GetPerimeter(shape)}");
                if (shape is Rectangle rect)
                {
                    Console.WriteLine($"Is square:{rect.IsSquare()}, Diagonal:{rect.Diagonal} ");
                    continue;
                }
                if(shape is Square sq)
                {
                    Console.WriteLine($"Diagonal:{sq.Diagonal}");
                    continue;
                }
            }
        }
    }
}