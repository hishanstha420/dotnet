namespace consoleInheritance2
{
    public class Teachers: Person
    {
        public string subject{get;}
        public Teachers(string sfirst_name,string smiddle_name,string slast_name, string sgender, int iage,string ssubject)
        {
            first_name=sfirst_name;
            middle_name=smiddle_name;
            last_name=slast_name;
            gender=sgender;
            age=iage;
            subject=ssubject;
        }

        public string GetInfo()
        {
            string s=base.GetInfo();
            s+="Subject :"+subject+ Environment.NewLine;
            return s;
        }
        

    }

}