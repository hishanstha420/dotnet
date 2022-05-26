using System;

 namespace first_program
 {
     class Program
     {
         static void Main(string[] args)// pass parameters from console
         {
            int input1,input2;
            int result;
            Console.WriteLine("Enter the first number:");
            input1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            input2=Convert.ToInt32(Console.ReadLine());
            Console.Write("Display the multiplication table\n");
            
            if(input1<input2)
            {
            if( input1>=1 && input1<=10 &&input2>=1 && input2<=10) 
            {
                for(int j=input1; j<=input2;j++)                  
                    {
                        for (int i = 1; i <= 10; i++)
                            {
                                result=j*i;
                                Console.WriteLine($"{j}*{i}= {result}");
                            }
                        Console.Write("\n");
                    }
            }
            else
            {
                Console.WriteLine("Number isnt between 1 and 10");
            }
            }
        else
        {
            Console.WriteLine("input1 is not smaller than input2");
        }

         }

     }
 }