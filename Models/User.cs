using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public abstract class BaseEntity{}
    public class User : BaseEntity
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2)]
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