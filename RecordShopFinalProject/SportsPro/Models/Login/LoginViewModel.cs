using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models.Login
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Please Enter A UserName")]
        [StringLength(50, ErrorMessage = "Username Must Be 50 characters or less")]
        public string UserName { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter A Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;




        public string ReturnUrl { get; set; } = string.Empty;

        public bool RememberMe { get; set; }




    }
}
