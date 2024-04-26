
// Used for [ValidateNever]
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;



/* Allows for the [Required] and the [Range]*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace RecordShop.Models
{
    public class ProductModel
    {


        // Read-Only Property for the /slug in the Program.cs file   This Shows the FirstName and the PhoneNumber
        public string Slug => ArtistName?.Replace(" ", "-").ToLower() + "-" + RecordName?.Replace(" ", "-").ToLower() + "-" /*+ Price?.ToString()*/;



        // Primary Key
        public int ProductModelId { get; set; }



        /*[Required(ErrorMessage = "Please Enter a Code")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Code's Must Have At Least 3 to 10 Characters")]
        public string? Code { get; set; } = string.Empty;*/



        [Required(ErrorMessage = "Please Enter a The Records Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Record Names Must Have At Least 1 to 50 Characters")]
        [Remote(action: "CheckRecordExists", controller: "ProductValidation", AdditionalFields = nameof(ArtistName) + "," + nameof(ProductModelId))]
        public string? RecordName { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter The Artists Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Artist's Names Must Have At Least 1 to 50 Characters")]
        public string? ArtistName { get; set; } = string.Empty;




        [Required(ErrorMessage = "Please Enter a Release Date")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Please enter a valid 4-digit year.")]
        [Range(1930, 2024, ErrorMessage = "Please enter a valid Release Date.")]
        public int? ReleaseDate { get; set; }

        // This will be called into the Product Controller when Adding so the current time can be set into this to be called into Details
        /*        [DataType(DataType.Date)]
                public DateOnly ReleaseDate { get; set; }*/




        [Required(ErrorMessage = "Please Enter a Price")]
        [Range(1, 1000000, ErrorMessage = "Price Must be Above $1 to $1,000,000 ")]
        public double? Price { get; set; }




        // Foreign Key Property  ~ Entity classes are easier to work with if you add Foreign Key properties that refer to the Primary Key in the related entity class
        [Required(ErrorMessage = "Please Enter a Genre")]
        public string GenreModelId { get; set; } = string.Empty;


        // NAVIGATION PROPERTY
        // Calls in our Genre Modal Class To be set to each Record   LINKS BOTH CLASSES TOGETHER
        [ValidateNever]
        public GenreModel Genre { get; set; } = null!;





        public string? ImageUrl { get; set; }




        // MANY TO MANY WITH CustomerModel    - Registrations Page
        public ICollection<CustomerModel> Customers { get; set; } = new List<CustomerModel>();








    }
}
