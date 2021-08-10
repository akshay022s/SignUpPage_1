using SignUpPageCore.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpPageCore.Models
{
    public class RegistrationModel
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }


        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Phone number is invalid")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Country Required")]
        [Display(Name = "Country")]
        public string CountryCode { get; set; }

        public List<CountryModel> CountryList { get; set; }

        [Required(ErrorMessage = "City Required")]
        [Display(Name = "City")]
        public string CityCode { get; set; }

        public List<CityModel> CityList { get; set; }


        [Required(ErrorMessage = "Gender Required")]
        [Display(Name = "Gender")]
        public GenderModel Genders { get; set; }
        public List<GenderModel> GenderList { get; set; }
        [ValidateCheckBox(ErrorMessage ="Please accept the Terms")]
        public bool Terms { get; set; }
    }


   
}
