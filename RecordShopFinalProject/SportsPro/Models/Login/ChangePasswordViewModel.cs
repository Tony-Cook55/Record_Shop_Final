using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models.Login
{
    public class ChangePasswordViewModel
    {


        public string Username { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter Your Password")]
        public string OldPassword { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter Your New Password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string NewPassword { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Confirm Your New Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;





    }
}
