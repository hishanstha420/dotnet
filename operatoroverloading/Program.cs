namespace operatorOverloading
{

    class Program
    {
        public static void Main()
        {
            Calculator calc1= new Calculator(15,20);
            Calculator calc2=new Calculator(5,5);
            calc1=calc1-calc2;
            calc1.print();
        }
    } 
    class Calculator
    {
        public int number1,number2;
        public Calculator(int num1, int num2)
        {
            number1=num1; number2=num2;

        }
        public static Calculator operator -(Calculator c1, Calculator c2)
        {
            c1.number1=c1.number1-c2.number1;
            c1.number2=c1.number2=c2.number2;
            return c1;
        }
        public void print()
        {
            Console.WriteLine("Number1="+number1);
            Console.WriteLine("Number2="+number2);
        }
    }

   
}
