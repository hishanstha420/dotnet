namespace consoleInheritance2
{
    public abstract class Person
    {
        public string first_name{get; set;}="";
        public  string middle_name{get; set;}="";
        public  string last_name{get;set;}="";
        public  string gender{get;set;}="";
        public int age{get;set;}=0;

        // public static string GetFirstName(Person person)
        // {
        //     return person.first_name;
        // }
        // public static string GetMiddlelName(Person person)
        // {
        //     return person.middle_name;
        // }
        // public static string GetLastlName(Person person)
        // {
        //     return person.last_name;
        // }
        // public static string GetGender(Person person)
        // {
        //     return peron.gender;
        // }
        // public static int age(Person person)
        // {
        //     return person.age;
        // }

        // Person(string sfirst_name,string smiddle_name,string slast_name, string sgender, int iage)
        // {
        //     first_name=sfirst_name;
        //     middle_name=smiddle_name;
        //     last_name=slast_name;
        //     gender=sgender;
        //     age=iage;
        // }
        public string full_name
        {
            get
            {
                
                return first_name +" "+(middle_name.Trim().Length>0?middle_name+" ":"")+" "+last_name;     
                
            }
        }
        public string GetInfo()
         {
            // string s=base.GetInfo();

            string s="Full Name:"+full_name +Environment.NewLine;
             s+="Gender :"+gender+ Environment.NewLine;
            s+="Age :"+age+ Environment.NewLine;
            return s;
         }
    }
}