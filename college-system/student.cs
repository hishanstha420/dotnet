namespace consoleInheritance2
{
    public class Students:Person
    {
        public string grade{get;}
        public int roll_no{get;}
        public Students(string sfirst_name,string smiddle_name,string slast_name, string sgender, int iage,string sgrade,int iroll_no)
        {
            first_name=sfirst_name;
            middle_name=smiddle_name;
            last_name=slast_name;
            gender=sgender;
            age=iage;
            grade=sgrade;
            roll_no=iroll_no;
        }
        // public string display()
        // {
        //     Console.WriteLine($"Student:{Environment.NewLine}Full Name={Person.full_name}");
        // }
         public string GetInfo()
         {
             string s=base.GetInfo();

            // string s="Full Name:"+full_name +Environment.NewLine;
             s+="Gender :"+gender+ Environment.NewLine;
            s+="Age :"+age+ Environment.NewLine;
            s+="Grade :"+grade+ Environment.NewLine;
            s+="Roll no :"+roll_no+ Environment.NewLine;
            return s;
         }
    }

}