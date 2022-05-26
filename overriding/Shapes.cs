namespace consoleInheritance
{
    public abstract class Shape
    {
        //an abstract property declaration doesnt provide an implementation of the program
        //it declares that the class supports properties, but leaves the accessor implementation

        public abstract double Area{get;}

        public abstract double Perimeter{get;}

        //public override string ToString()=>GetType().Name;
        
        public override string ToString()
        {
            return GetType().Name;
        }
        public static double GetArea(Shape shape)
        {
            return shape.Area;
        }
        public static double GetPerimeter(Shape shape)
        {
            return shape.Perimeter;
        }
    }
}