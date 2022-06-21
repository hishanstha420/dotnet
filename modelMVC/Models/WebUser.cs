
using System.ComponentModel.DataAnnotations;
namespace modelMVC.Models
{
    public class WebUser
    {
        // public string FirstName {get;set;}
        // public string LastName {get; set}
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";

        [Required]
        [StringLength(10)]
        public string LastName { get; set; } = "";
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
    }
}