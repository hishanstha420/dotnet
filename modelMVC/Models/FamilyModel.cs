namespace modelMVC.Models
{
    public class FamilyModel
    {
        public int id { get; set; } = 0;

        public string fullName { get; set; } = "";

        public Gender gender { get; set; } = Gender.male;

        public int Age { get; set; } = 0;

        public Relation relation { get; set; } = Relation.None;

        public FamilyModel()
        {
            id = 0;
            fullName = "";
            gender = Gender.male;
            Age = 0;
            relation = Relation.None;
        }

        public FamilyModel(int iid, string sfullName, Gender sgender, int iage, Relation erelation)
        {
            id = iid;
            fullName = sfullName;
            gender = sgender;
            Age = iage;
            relation = erelation;

        }

        public override string ToString()
        {
            return $"ID:{id}, Full Name:{fullName} Gender:{gender}{Environment.NewLine}" +
            $" Age:{Age}{Environment.NewLine} |Relation:{relation}";
        }
    }

    public enum Relation
    {
        Father,
        Monther,
        Brother,
        Sister,
        None
    }
    public enum Gender
    {
        male, female, Other
    }





}