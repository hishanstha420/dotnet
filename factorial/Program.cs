using System;
namespace factorial_program
    {
        class factorial 
        {
            static void Main(string[] args)
            {
                int number, factorial=1;
                Console.WriteLine("Enter number whose factorial is to be calculated");
                number=Convert.ToInt32(Console.ReadLine());
                for (int i =1; i<=number; i++)
                {
                    factorial=factorial*i;
                    
                }
                Console.WriteLine($"Factorial of {number} is {factorial}");
            }
        }
    }