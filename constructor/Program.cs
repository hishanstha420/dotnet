using System;
namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Shape(10, 20,1);
            Console.WriteLine($"volume={rectangle.Volume()}{Environment.NewLine}Area={rectangle.Area()}{Environment.NewLine}Perimeter={rectangle.perimeter()}");
        }
    }
    public class Shape
    {
        public double length {get; set;}
        public double breadth {get; set;}
        public double height {get; set;}
        // length= Convert.ToDouble(Console.ReadLine());
        // breadth= Convert.ToDouble(Console.ReadLine());
        // height= Convert.ToDouble(Console.ReadLine());

        public Shape()
        {
            length=0;
            breadth=0;
            height=0;
        }
        public Shape(double dLength, double dBreadth)
        {
            length=dLength;
            breadth=dBreadth;
            
        }
        public Shape(double dLength, double dBreadth, double dHeight)
        {
            length=dLength;
            breadth=dBreadth;
            height=dHeight;
        }
        public double Area()
        {
            if (height==0)
            {
                return length*breadth;
            }
            else
            {
                return length*breadth*height;
            }

        }
        public double Volume()
        {
            return length*breadth*height;
        }

        public double perimeter()
        {
            return 2*(length+breadth);
        }

        
    }
}