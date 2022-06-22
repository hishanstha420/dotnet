using Microsoft.AspNetCore.Mvc;
// using ModelBindingMVC.Models;
using modelMVC.Models;
using ModelBindingMVC.Models;

namespace ModelBindingMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]

        public IActionResult WebUser()
        {
            return View(new WebUser()
            {
                FirstName = "Aayush",
                LastName = "Pandit",
                Email = "Aayushpabdit@gmail.com"
            });
        }
        [HttpPost]
        public IActionResult WebUser(WebUser webuser)
        {
            if (ModelState.IsValid)
            {
                return Content($"Hello {webuser.FirstName} Updated Successfully");
            }
            else
            {
                return Content("Model couldn't be validated");
            }
        }


        [HttpGet]

        public IActionResult Femely()
        {
            return View(new FamilyModel { id = 1, fullName = "Hishan Shrestha", gender = "Select Gender", Age = 22, relation = Relation.None });
        }
        [HttpPost]
        public IActionResult FemelyShow(FamilyModel familyModel)
        {
            // return Content($"ID:- {familyModel.id}{Environment.NewLine} " +
            // $"Full Name:-{familyModel.fullName}{Environment.NewLine} " +
            // $"Gender:-{familyModel.gender}{Environment.NewLine} " +
            // $"Age:-{familyModel.Age}{Environment.NewLine} " +
            // $"Relation:-{familyModel.relation}{Environment.NewLine} "
            // );
            var list = new List<FamilyModel>();
            list.Add(familyModel);
            return View(list);
        }
        [HttpGet]
        public IActionResult Math()
        {
            return View(new MathModel { num1 = 0, num2 = 0 });
        }
        [HttpPost]
        public IActionResult Math(MathModel u)
        {
            return View(u);

        }
    }
}