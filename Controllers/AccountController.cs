using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SignUpPageCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpPageCore.Controllers
{
     
    public class AccountController : Controller
    {
        
         

        public IActionResult SignUp()
        {
            RegistrationModel mod = new RegistrationModel();
            // Adding Static Gender Data
            mod.GenderList = new List<GenderModel> { new GenderModel { ID = "M", Type = "Male" }, new GenderModel { ID = "F", Type = "Female" } };
            //  Adding Static Country List
            ViewBag.CountryList = new List<CountryModel> { new CountryModel { CountryCode = "IN", CountryName = "India" }, new CountryModel { CountryCode = "USA", CountryName = "United States Of America" }, new CountryModel { CountryCode = "CN", CountryName = "China" } };
            mod.CountryList =  new List<CountryModel> { new CountryModel { CountryCode = "IN", CountryName = "India" }, new CountryModel { CountryCode = "USA", CountryName = "United States Of America" }, new CountryModel { CountryCode = "CN", CountryName = "China" } };
            
            return View(mod);
        }

        [HttpGet]
        public JsonResult CityList(string CountryCode)
        {

          

            List<CityModel> Cities = new List<CityModel> { new CityModel { CountryCode = "IN", CityName = "Mumbai",CityCode="MUM" },
                                                       new CityModel { CountryCode = "IN" , CityName = "Delhi",CityCode="DEL" },
                                                       new CityModel { CountryCode = "USA",  CityName = "California",CityCode="CAL" },
                                                       new CityModel { CountryCode = "USA",  CityName = "New York",CityCode="NWY" },
                                                       new CityModel { CountryCode = "USA",  CityName = "New Jersey",CityCode="NWJ" },
                                                       new CityModel { CountryCode = "CN" , CityName = "Beijing",CityCode="BGN" },
                                                                         };
            var citylist = from s in Cities
                        where s.CountryCode == CountryCode.ToString()
                        select s;

            return Json(new SelectList(citylist.ToArray(), "CityCode", "CityName"));
        }
    }
}
