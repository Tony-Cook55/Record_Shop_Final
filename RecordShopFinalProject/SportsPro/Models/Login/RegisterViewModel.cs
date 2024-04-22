using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models.Login
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Please Enter A First Name")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "First Name Must Be 20 characters or less")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter A Last Name")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Last Name Must Be 20 characters or less")]
        public string LastName { get; set; } = string.Empty;





        [Required(ErrorMessage = "Please Enter A UserName")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Username Must Be 25 characters or less")]
        public string UserName { get; set; } = null!;


        [Required(ErrorMessage = "Please Enter A Password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = null!;


        [Required(ErrorMessage = "Please Enter A Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;


        [Required(ErrorMessage = "Please Enter A Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
    }
}
