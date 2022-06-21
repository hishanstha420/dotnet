using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class FamilyController : Controller
    {
        [HttpGet("GetFamily")]
        public IEnumerable<FamilyModel> Get()
        {
            var list = new List<FamilyModel>()
            {
                new FamilyModel(1,"Aayush Pandit","Male",22,Relation.Father),
                new FamilyModel(2,"Aayush Pandit","Male",22,Relation.Father),
                new FamilyModel(3,"Aayush Pandit","Male",22,Relation.Father)
            };
            return list.ToArray();
        }
        [HttpGet("GetFamily/{id:int?}")]
        public IEnumerable<FamilyModel> GetBy(int id = 1)
        {
            var list = new List<FamilyModel>()
            {
                new FamilyModel(1,"Aayush Pandit","Male",22,Relation.Father),
                new FamilyModel(2,"Aayush Pandit","Male",22,Relation.Father),
                new FamilyModel(3,"Aayush Pandit","Male",22,Relation.Father)

            };

            var list2 = new List<FamilyModel>();
            list2.Add(list.Where(p => p.id == id).FirstOrDefault());
            return list2.ToArray();
        }

        [HttpGet("GetFamily/{gender}")]
        public IEnumerable<FamilyModel> GetBy(string gender)
        {
            var list = new List<FamilyModel>(){
            new FamilyModel(1,"Aayush Pandit","Male",22,Relation.Father),
            new FamilyModel(2,"Aayush Pandit","Male",22,Relation.Father),
            new FamilyModel(3,"Aayush Pandit","Male",22,Relation.Father)

            };


            var list2 = list.Where(p => p.gender == gender).ToList();
            return list2.ToArray();
        }
    }
}