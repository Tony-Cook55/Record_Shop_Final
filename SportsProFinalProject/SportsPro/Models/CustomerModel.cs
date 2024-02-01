using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models
{
    public class CustomerModel
    {


        // Read-Only Property for the /slug in the Program.cs file   This Shows the FirstName and the LastName
        public string Slug => CustomerFirstName?.Replace(" ", "-").ToLower() + "-" + CustomerLastName?.Replace(" ", "-").ToLower();






        // Primary Key
        public int CustomerModelId { get; set; }



        [Required(ErrorMessage = "Please Enter a First Name")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "First Names Must Have At Least 1 to 20 Characters")]
        public string? CustomerFirstName { get; set; } = string.Empty;



        [Required(ErrorMessage = "Please Enter a Last Name")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Last Names Must Have At Least 1 to 20 Characters")]
        public string? CustomerLastName { get; set; } = string.Empty;



        [Required(ErrorMessage = "Please Enter a Address")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Address's Must Have At Least 1 to 50 Characters")]
        public string? Address { get; set; } = string.Empty;




        [Required(ErrorMessage = "Please Enter a City")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "City Must Have At Least 1 to 50 Characters")]
        public string? City { get; set; } = string.Empty;



        [Required(ErrorMessage = "Please Enter a State")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "States Must Have At Least 1 to 50 Characters")]
        public string? State { get; set; } = string.Empty;




        [Required(ErrorMessage = "Please Enter a Postal Code")]
        [StringLength(9, MinimumLength = 5, ErrorMessage = "Postal Codes Must Have At Least 5 to 9 Digits")]
        /*[Range(10000, 99999, ErrorMessage = "Postal Codes Must be 5 Digits")]*/ // IF STRING
        public string? PostalCode { get; set; } = string.Empty;





        /*        [Required(ErrorMessage = "Please Enter An Email")]
        */
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Email Must Have At Least 1 to 50 Characters")]
        public string? Email { get; set; } = string.Empty;


/*        [Required(ErrorMessage = "Please Enter a Phone Number")]*/
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number in the format xxx-xxx-xxxx")]
        /*[StringLength(15, MinimumLength = 4, ErrorMessage = "Phone Numbers Must Be Between 8 and 15 Digits Long")]*/
        public string? PhoneNumber { get; set; } = string.Empty;








        // Foreign Key Property  ~ Entity classes are easier to work with if you add Foreign Key properties that refer to the Primary Key in the related entity class
        [Required(ErrorMessage = "Please Enter a Country")]
        public string CountryModelId { get; set; } = string.Empty;


        // NAVIGATION PROPERTY
        // Calls in our Country Modal Class To be set to each Customer   LINKS BOTH CLASSES TOGETHER
        [ValidateNever]
        public CountryModel Country { get; set; } = null!;







    }
}
