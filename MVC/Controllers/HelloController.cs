
using Microsoft.AspNetCore.Mvc;
using WebApplicationGui.Classes;

namespace mvc_web_app.Controllers;

public class HelloController : Controller
{
    string msg = "Hello World";

    FamilyModel xx = new FamilyModel();

    public IActionResult index()
    {
        ViewData["Message"] = msg;
        ViewData["Num"] = 10;
        return View();
    }


    public IActionResult searchData(int id = 1)
    {
        var list = new List<FamilyModel>()
        {
            new FamilyModel(1,"Aayush Pandit","Male",22,Relation.Father),
            new FamilyModel(2,"Aayush Pandit","Male",22,Relation.Father),
            new FamilyModel(3,"Aayush Pandit","Male",22,Relation.Father),

        };
        var list2 = new List<FamilyModel>();
        list2.Add(list.Where(p => p.id == id).FirstOrDefault());
        return View(list2);
    }

    public IActionResult GetData()
    {
        // xx=new FamilyModel(1,"Aayush Pandit","Male",22,Relation.Father);
        //ViewData["data"]=xx.ToString();

        int iId = 0;
        string sFullName = HttpContext.Request.Form["txtFullName"].ToString();
        string sGender = HttpContext.Request.Form["txtGender"].ToString();
        int iAge = Convert.ToInt32(HttpContext.Request.Form["numAge"].ToString());
        int iRelation = Convert.ToInt32(HttpContext.Request.Form["txtRelation"].ToString());
        var list = new List<FamilyModel>()
        {
            new FamilyModel(1,"Aayush Pandit","Male",22,Relation.Father),
            new FamilyModel(2,"Aayush Pandit","Male",22,Relation.Father),
            new FamilyModel(3,"Aayush Pandit","Male",22,Relation.Father),

        };
        list.Add(new FamilyModel(iId, sFullName, sGender, iAge, (Relation)iRelation));
        //ViewData["test"]="Testing right now!!!"; //j rakhna ni milcha dict ma, dictionary ho, default chai string linxa
        return View(list);





    }
    public IActionResult AddData()
    {
        // xx=new FamilyModel(1,"Aayush Pandit","Male",22,Relation.Father);
        ViewData["data"] = xx.ToString();

        var list = new List<FamilyModel>()
        {
            new FamilyModel(1,"Aayush Pandit","Male",22,Relation.Father),
            new FamilyModel(2,"Aayush Pandit","Male",22,Relation.Father),
            new FamilyModel(3,"Aayush Pandit","Male",22,Relation.Father)

        };
        // ViewData["test"]="Testing right now!!!"; //j rakhna ni milcha dict ma, dictionary ho, default chai string linxa
        return View(list);
    }
}



