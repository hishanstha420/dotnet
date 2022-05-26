
using System;

 namespace first_program
 {
     class Program
     {
         static void Main(string[] args)// pass parameters from console
         {
             Student mahesh_details= new Student(1,2,"Mahesh","Kumari","chapagain","Others","buddhanagar","Kathmandu");
             Student mama_details= new Student(2,13,"Devesh","Kumari","Moondaal","Others","New Baneshwor","Kathmandu");
             
            Console.WriteLine(mahesh_details.display());
            Console.WriteLine(mama_details.display());
            Student s=new Student();
            
            Console.WriteLine(s.full_name);

         }
     }
    class Student
    {
        public int id {get; set;} = 0;
        public int roll_no {get; set;} = 0;
        public string first_name {get; set;} = "";
        public string middle_name{get;set;}="";
        public string last_name{get;set;}="";
        public string gender{get;set;}="";
        public string address{get;set;}="";
        public string district{get;set;}="";
        //Ternar operator (Condition?True part:False part)
        public string full_name
        {
            get
            {
                
                return first_name +" "+(middle_name.Trim().Length>0?middle_name+" ":"")+" "+last_name;     
                
            }
        }

        public Student() //#Default constructor mathi ko  private string district{get;set;}=""; yesma ="" hatauney default constructor use garey
        {
            id=0;
            first_name="";
            middle_name="";
            last_name="";
            address="";
            district="";
        }
        public Student(int iId, int iRollNo, string sFirstName,string sMiddleName, string sLastName,string sGender, string sAddress,string sDistrict)
        {
            id=iId;
            roll_no=iRollNo;
            first_name=sFirstName;
            middle_name=sMiddleName;
            last_name=sLastName;
            gender=sGender;
            address=sAddress;
            district=sDistrict;

            //Console.WriteLine($"{Environment.NewLine} id={id} rollno={roll_no} firstname={first_name} {middle_name} {last_name} {address} {district} ");   
        }

        public string display()

        {
            Console.WriteLine($"Hello there!!!!{Environment.NewLine}Your details are as follows:");
            return $"ID:-{id+Environment.NewLine}Roll no:-{roll_no+Environment.NewLine}"+
            $"Name:-{full_name+Environment.NewLine}gender:-{gender+Environment.NewLine}"+
            $"Address:-{address+Environment.NewLine}District:-{district+Environment.NewLine}";
        }    
    }
    
 }