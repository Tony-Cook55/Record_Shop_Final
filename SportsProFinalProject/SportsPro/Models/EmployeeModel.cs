using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models
{
    public class EmployeeModel
    {


        // Read-Only Property for the /slug in the Program.cs file   This Shows the FirstName and the Last Name
        public string Slug => FirstName?.Replace(" ", "-").ToLower() + "-" + LastName?.Replace(" ", "-").ToLower()/* + "-" + Price?.ToString()*/;






        // Primary Key
        public int EmployeeModelId { get; set; }



        [Required(ErrorMessage = "Please Enter a First Name")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "First Names Must Have At Least 1 to 20 Characters")]
        public string? FirstName { get; set; } = string.Empty;



        [Required(ErrorMessage = "Please Enter a Last Name")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Last Names Must Have At Least 1 to 20 Characters")]
        public string? LastName { get; set; } = string.Empty;




        [Required(ErrorMessage = "Please Enter An Email")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Email Must Have At Least 1 to 50 Characters")]
        public string? Email { get; set; } = string.Empty;



        [Required(ErrorMessage = "Please Enter a Phone Number")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number in the format xxx-xxx-xxxx")]
        /*[StringLength(15, MinimumLength = 4, ErrorMessage = "Phone Numbers Must Be Between 8 and 15 Digits Long")]*/
        public string? PhoneNumber { get; set; } = string.Empty;







    }
}
