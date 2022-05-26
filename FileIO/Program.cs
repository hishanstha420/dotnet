using System;
using System.IO;

namespace FileIO
{
    class PrintString
    {
        static FileStream fs; //file read write gana lai use garinxa FileStream
        static StreamWriter sw;//yesley chai memory ma load garne kaam garxa

        static string file_name="test.txt";

        //this method prints to a file
        public static void WriteToFile(string s)
        {
            fs=new FileStream(file_name,FileMode.Append,FileAccess.Write);
            sw=new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void WriteAllText()
        {
            File.WriteAllText(file_name,"Hello World");
        }

        public static void ReadFromFile()
        {
            if (File.Exists(file_name))
            {
                string[] lines=File.ReadAllLines(file_name);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void Main(string[] args)
        {
            //WriteAllText();
            WriteToFile("Hello World1");
            WriteToFile("Hello World2");
            WriteToFile("Hello World3");
            ReadFromFile();
            Console.ReadKey();
        }
    }
}