using System;

 namespace first_program
 {
     class Program
     {
         static void Main(string[] args)// pass parameters from console
         {
            
             Console.WriteLine("What is Your Name");//printf ko kaam garxa
             var name =Console.ReadLine(); //var->value j xa tei anusar lae variable ko type linxa
             var currentDate=DateTime.Now;//scanf
            //  Console.WriteLine("Hello "+name+" on "+currentDate.Date+" at "+currentDate.TimeOfDay);
            Console.WriteLine($"{Environment.NewLine}Hello,{name}, on {currentDate:d} at {currentDate:t}");//$->string interpolation
            //Environment.NewLine=> new line like br of html /n of C  :d represents date and :t represents time of current time
            Console.WriteLine($"{Environment.NewLine}Press any Key to Exit....");
            Console.ReadKey(true);
           
         }

     }
 }