namespace multiplication
{
    class program
    {
        public static void Main()
        {
            int [,] arr=new int[3,2]
        {
            {2,3},
            {3,4},
            {2,2}
        };
        
        int mul=1,i,j;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                mul=mul*arr[i,j];
            }
            Console.WriteLine($"{arr[i,j]}*{arr[i,j]}={mul}");
            mul=1;
        }

        }
    }
}