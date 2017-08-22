using System.ComponentModel.DataAnnotations;

namespace validatingFormSubmission.Models
{
    public abstract class BaseEntity{}
    public class User : BaseEntity
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}

        [Required]
        public int Age {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}