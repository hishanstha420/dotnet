public class ArrayTest
{
    public static void Main()
    {
        //Jagged Array
        int [][] jArray=new int[2][]
        {
            new int[3]{1,2,3},
            new int[4]{4,5,6,7}
        };
        Console.WriteLine(jArray[0][1]);
        Console.WriteLine(jArray[1][0]);

        //2D Array
        int[,] arr2d= new int[3,2]{
            {1,2},
            {3,4},
            {5,6}
        };
        Console.WriteLine(arr2d[0,1]);

//Pass by value
        int m,n;
        Console.WriteLine(Multiply(2,out m,out n));
        //Multiply(2,out m,out n);
        Console.WriteLine(m);
        Console.WriteLine(n);

    //Pass by Reference 
        int aa=5;
        Multiply2(ref aa);
        Console.WriteLine(aa);
    }
    
    //Pass by value
    public static int Multiply(int x, out int x3,out int x4)
    {
        x3=x*3;
        x4=x*4;
        return x*2;
    }

    //Pass by Reference
    public static void Multiply2(ref int x)
    {
        x=x*3;
    }

}