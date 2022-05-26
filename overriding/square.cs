namespace consoleInheritance
{
    public class Square:Shape{
        public Square(double length)
        {
            Side=length;
        }
        public double Side{get;}
        public override double Area=>Math.Pow(Side,2);
        // {
        //     get{
        //         return Math.Pow(Side,2);
        //     }
        // }
        public override double Perimeter=>Side*4;
        // {
        //     get
        //     {
        //         return Side*4;
        //     }

        // }
        public double Diagonal =>Math.Round(Math.Sqrt(2)*Side,2);
        // {
        //     get
        //     {
        //         return Math.Round(Math.Sqrt(2)*Side,2);
        //     }
        // }
    }
    
}