using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Registration.Models
{
    [Table("Registration")]
    public class RegistrationModel {

        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [RegularExpression(@"\d{1,2}/\d{1,2}/\d{4}", ErrorMessage = "Enter DD/MM/YYYY format")]
        public string DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Contact")]
        [RegularExpression("[6789][0-9]{9}", ErrorMessage = "Enter Valid Mobile Number")]
        public string Contact { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Identity Type")]
        public string IdentityType { get; set; }

        [Required]
        [Display(Name = "Identity Value")]
        public string IdentityValue { get; set; }

        [Required]
        [Display(Name = "10th Percentage")]
        [Range(0.00, 100.00)]
        public float? SchoolPercentage { get; set; }

        [Required]
        [Display(Name = "12th Percentage")]
        [Range(0.00, 100.00)]
        public float? HighSchoolPercentage { get; set; }

        [Required]
        [Display(Name = "Qualification")]
        public string Qualification { get; set; }

        [Required]
        [Display(Name = "Stream")]
        public string Stream { get; set; }

        [Required]
        [Display(Name = "College Name")]
        public string CollegeName { get; set; }

        [Required]
        [Display(Name = "University")]
        public string University { get; set; }

        [Required]
        [Display(Name = "Year of Passing")]
        public string YearOfPassing { get; set; }

        [Required]
        [Display(Name = "Percentage/CGPA")]
        [Range(0.00, 100.00)]
        public float? CollegePercentage { get; set; }

        [Required]
        [Display(Name = "Drive Type")]
        public string DriveType { get; set; }
        
        [Required]
        [Display(Name = "Venue")]
        public string Venue { get; set; }

        [Display(Name = "Reference")]
        public string Reference { get; set; }
    }
    
}
