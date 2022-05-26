using System;

namespace DelegateApp
{
    delegate int NumberChanger(int n);

    class TestDelegate
    {
        static int num=10;
        public static int Addnum(int p)
        {
            num+=p;
            return num;
        }
        public static int Multiplynum(int q)
        {
            num*=q;
            return num;
        }
        public static int getnum()
        {
            return num;
        }
        
    
        static void Main()
        {
            NumberChanger nc1= new NumberChanger(Addnum);
            NumberChanger nc2= new NumberChanger(Multiplynum);
            nc1(25);
            Console.WriteLine("Value of num: {0}",getnum());
            nc2(5);
            Console.WriteLine("Value of num: {0}",getnum());
            Console.ReadKey();
        }
    }
}