using System.Collections.Generic;

namespace consoleInheritance2
{
    class Program
    {
        static void Main(string[] args)
                {

                //USING ARRAY

            // Person[] persons={new Students("Hishan","","Shrestha","Male",22,"A",25),
            // new Students("Hishan","","Shrestha","Male",22,"A",22),
            // new Students("Hishan","","Shrestha","Male",22,"A",22),
            // new Teachers("Rabi","","Shrestha","Male",45,"Netcentric"),
            // new Teachers("Phul","Babu","Pandit","Others",55,"TOC")
            // };

           //Using List

            // List <Person> persons=new List <Person>();
            // persons.Add(new Students("Hishan","","Shrestha","Male",22,"A",25));
            // persons.Add( new Students("Amresh","Kumar","chaudhary","Male",22,"A",22));
            // persons.Add(new Students("Aayush","","Raut","Male",25,"A",04));
            // persons.Add(new Teachers("Rabi","","Shrestha","Male",45,"Netcentric"));
            // persons.Add(new Teachers("Phul","Babu","Pandit","Others",55,"TOC"));
            
            //another way
            // var persons=new List <Person>();
            // persons.Add(new Students("Hishan","","Shrestha","Male",22,"A",25));
            // persons.Add( new Students("Amresh","Kumar","chaudhary","Male",22,"A",22));
            // persons.Add(new Students("Aayush","","Raut","Male",25,"A",04));
            // persons.Add(new Teachers("Rabi","","Shrestha","Male",45,"Netcentric"));
            // persons.Add(new Teachers("Phul","Babu","Pandit","Others",55,"TOC"));

            var persons=new List <Person>(){
            new Students("Hishan","","Shrestha","Male",22,"A",25),
            new Students("Amresh","Kumar","chaudhary","Male",22,"A",22),
            new Students("Aayush","","Raut","Male",25,"A",04),
            new Teachers("Rabi","","Shrestha","Male",45,"Netcentric"),
            new Teachers("Phul","Babu","Pandit","Others",55,"TOC")
            
            };
        foreach (Person person in persons)
        {
            if (person is Students student) 
            {
                Console.WriteLine(student.GetInfo());
                continue;
            }
            if(person is Teachers teacher)
            {
                Console.WriteLine(teacher.GetInfo());
                
            }
            
        }
            
        }
    }
}