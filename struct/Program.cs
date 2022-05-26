namespace Struture
{
    class teststructure
    {
    
        public static void Main()
        {
            Books[] books= {
                new Books("Dot net","Heralal","Rabi shrestha"),
                new Books("C","Someone","Rabin shrestha"),
                new Books("C++","Noone","Rabina shrestha")
            };
        foreach (Books book in books)
        {
            Console.WriteLine(book.getInfo());
            
        }
    

        }
    }
    public struct Books
    {
        public string title;
        public string author;
        public string teacher;

        public Books(string sTitle, string sAuthor, string steacher)
        {
            title=sTitle;
            author=sAuthor;
            teacher=steacher;
        }
        public string getInfo()
        {
            string full="";
            full+="Title="+title+ Environment.NewLine;
            full+="Author= "+author+Environment.NewLine;
            full+="Teacher= "+teacher+Environment.NewLine;
            return full;

        }
    }

}